global using BlazorPWA.Shared.Models;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore;
global using MudBlazor.XS.Common.Helpers;
global using XpertStudio.Common.Attributes;
global using XpertStudio.Common.Enums;
global using XpertStudio.Common.Data;

using BL.Services;
using BlazorPWA.Server;
using BlazorPWA.Server.Controllers;
using BlazorPWA.Shared.Managers;
using common.OFM;
using CommonServices;
using GenericCrudApi.Controllers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.IdentityModel.Tokens;
using MudBlazor.XS.Client.Services;
using MudBlazor.XS.Common.Authorization;
using System.Data.Common;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using XpertStudio.Common.Database;
using XpertStudio.Common.DTOs;
using XpertStudio.Common.Globals;
using XpertStudio.Framework.Domain;
using XS.ASPNetCore.Server.Authorization;
using XS.ASPNetCore.Server.Data;
using XS.ASPNetCore.Server.Models;
using XS.ASPNetCore.Server.Services;
using static MudBlazor.CategoryTypes;




var builder = WebApplication.CreateBuilder(args);
string jwtIssuer = builder.Configuration["JwtIssuer"];
string jwtAudience = builder.Configuration["JwtAudience"];
string jwtSecurityKey = builder.Configuration["JwtSecurityKey"];
bool GenerateMenu = false;
StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);
DbProviderFactories.RegisterFactory("Microsoft.EntityFrameworkCore.SqlServer", Microsoft.Data.SqlClient.SqlClientFactory.Instance);
//DbProviderFactories.RegisterFactory("Microsoft.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
//DbProviderFactories.RegisterFactory("System.Data.SQLite", System.Data.SQLite.SQLiteFactory.Instance);

//set connection
SetConnection();

//authentication and authorization
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(XSDBFunctionality.connectionString));

builder.Services.AddDefaultIdentity<XSUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<DataContext>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtIssuer,
                ValidAudience = jwtAudience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecurityKey)),
                ClockSkew = TimeSpan.FromSeconds(0)
            };
        });
//builder.Services.AddScoped<XSAuthorizeAttribute>();
//builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
builder.Services.AddScoped<IAuthorizationHandler, ComponentAccessHandler>();
builder.Services.AddScoped<IAuthorizationHandler, ControllerAccessHandler>();

builder.Services.AddAuthorization(config =>
{
    config.AddPolicy(Policies.IsSuperAdmin, Policies.IsSuperAdminPolicy());
    config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
    config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
    config.AddPolicy(Policies.IsAnonymousUser, Policies.IsAnonymousUserPolicy());
    config.AddPolicy(Policies.IsDomainUser, policy =>
    {
        policy.Requirements.Add(new ComponentAccessRequirement());
    });
    config.AddPolicy(Policies.IsDomainUser, policy =>
    {
        policy.Requirements.Add(new ControllerAccessRequirement());
    });
});


builder.Services.AddScoped<XS.ASPNetCore.Server.Services.IAuthService, XS.ASPNetCore.Server.Services.AuthService>();
builder.Services.AddScoped<IUserAccountService, UserAccountService>();


// Add services to the container.
if (Debugger.IsAttached)
{
    var SolutionDirectory = Path.GetFullPath(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\..\\..\\"));
    DomainLayerData.XSMetadataDirectory = SolutionDirectory + "\\" + "XSMetadata";
    if (GenerateMenu == true)
    {
        //generate menu
        XSProjectDto.InitializeCommon(SolutionDirectory);
        var menuGen = new XpertStudio.CodeGeneration.BlazorPWAMenuGenerator("XpertMenu");
        menuGen.Generate();
    }
}
else
{
    DomainLayerData.XSMetadataDirectory = "XSMetadata";
}
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddControllers()
                .AddApplicationPart(typeof(XpertControllerBase<>).Assembly) // Add the assembly of the generic controllers
                .AddJsonOptions(options =>
                 {
                     //options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                    // options.JsonSerializerOptions.Converters.Add(new DateTimeConverter());
                 });


var assembly = typeof(BL.Services.XpertServiceBase).Assembly;//Assembly.Load("OMS.Domain");
var types = from type in assembly.GetTypes()
            select type;
types = types.OrderBy(t => t.Name).ToArray();

foreach (var type in types)
{
    if (type.GetInterface(typeof(IXpertCommonDataProxyDomain<>).Name.ToString()) != null)
    {
        var rep = types.Where(o => type.IsAssignableFrom(o) && o != type).FirstOrDefault();
        if (rep != null)
        {
            builder.Services.AddScoped(type, rep);
        }
    }
    if (type.GetInterface(typeof(IXpertCrudFunctionsDomain<>).Name.ToString()) != null)
    {
        //OMS.Domain.DomainRepositories.clsCoolieBookingRepository
        //services.AddScoped(type);
        var ser = types.Where(o => type.IsAssignableFrom(o) && o != type)?.FirstOrDefault();
        if (ser != null)
        {
            builder.Services.AddScoped(type, ser);
        }
    }
    if (type.GetInterface(typeof(IXpertDomainMethods<>).Name.ToString()) != null)
    {
        var ser = types.Where(o => type.IsAssignableFrom(o) && o != type)?.FirstOrDefault();
        if (ser != null)
        {
            builder.Services.AddScoped(type, ser);
        }
    }
    //register XpertServiceBase
    builder.Services.AddScoped(typeof(ICommonDBMethods), typeof(XpertServiceBase));

}

builder.Services.AddXpertControllers();

//athentication and authorization


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");
});
//update assembly in domain layer
DomainLayerData.BlazorServerAssemblyName = Assembly.GetExecutingAssembly().FullName;
DomainLayerData.BlazorServerAssemblyFilePath = Assembly.GetExecutingAssembly().Location;
//client
var ClientAssembly = Assembly.GetAssembly(typeof(UserAccountManager));
DomainLayerData.BlazorUIAssemblyName = ClientAssembly?.FullName;
DomainLayerData.BlazorUIAssemblyFilePath = ClientAssembly?.Location;
//var dataProxy = new clsCoolieMasterRepository();
//IclsCoolieMasterService obj = (IclsCoolieMasterService)new clsCoolieMasterService(dataProxy);
//var data = await obj.GetAllPaginated(1, 10);
app.Run();
static void SetConnection()
{
    // set sql server connection string to common dll

    string line;
    int Line_No = 0;
    System.IO.StreamReader objReader = new System.IO.StreamReader("config.Txp");
    while (objReader.Peek() != -1)
    {
        line = objReader.ReadLine();
        if (Line_No == 0)
        {
            XSDBFunctionality.SetConnectionEncryptFormat(line);
            //clsDBFuncationality.SetConnectionEncryptFormat(line);
        }

        else if (Line_No == 1)
        {
            XSDBFunctionality.SetConnectionEncryptFormat2(line);
            //clsDBFuncationality.SetConnectionEncryptFormat2(line);
        }

        else
            throw new Exception("More than two connections in config file not supported.");
        Line_No = Line_No + 1;
    }
    // set domain connection
    CurrentConnection.DomainConnection = new DBConnection { _ConnectionDBType = ConnectionDBType.SQLServer, _ConnectionString = XSDBFunctionality.connectionString };
    //set metadata connection
    //CurrentConnection.MetadataConnection = new DBConnection { _ConnectionDBType = ConnectionDBType.SQLite, _ConnectionString = "data source=|DataDirectory|\\XpertStudio.db" };
    CurrentConnection.MetadataConnection = new DBConnection { _ConnectionDBType = ConnectionDBType.SQLite, _ConnectionString = "name=XpertContext" };
    //XSqliteDbConfiguration dbConfig = new XSqliteDbConfiguration();            
    //DbConfiguration.SetConfiguration(dbConfig);

    // set other parameters
    //objCommonVar.CurrentUserCode = "admin";
    //objCommonVar.CurrentUserName = "admin";
    //objCommonVar.CurrentCompanyCode = "Tecxpert";

}