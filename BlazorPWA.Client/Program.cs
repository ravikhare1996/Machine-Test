global using Blazored.LocalStorage;
global using BlazorPWA.Client;
global using BlazorPWA.Shared.Models;
global using MudBlazor;
global using MudBlazor.Components.XS;
global using MudBlazor.Components.XS.Buttons;
global using MudBlazor.Components.XS.Design;
global using MudBlazor.XS.Client.Services;
global using MudBlazor.XS.Common;
global using MudBlazor.XS.Common.Helpers;
global using System.Net.Http.Json;
global using System.Security.Claims;
global using XpertStudio.Common.Attributes;
global using XpertStudio.Common.Dtos;
global using XpertStudio.Common.DTOs;
global using XpertStudio.Common.Enums;
using BlazorPWA.Client.Shared;
using BlazorPWA.Shared;
using BlazorPWA.Shared.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
//using CommonServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Localization;
using MudBlazor.Models;
using MudBlazor.Services;
using MudBlazor.XS.Common.Authorization;
using System.Reflection;
using XpertStudio.Common.Database;
using XpertStudio.Common.Globals;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//authorization
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserAccountManager, UserAccountManager>();


builder.Services.AddBlazoredLocalStorage();

builder.Services.AddAuthorizationCore(config =>
{
    config.AddPolicy(Policies.IsSuperAdmin, Policies.IsSuperAdminPolicy());
    config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
    config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
    config.AddPolicy(Policies.IsAnonymousUser, Policies.IsAnonymousUserPolicy());
    config.AddPolicy(Policies.IsDomainUser, policy =>
    {
        policy.Requirements.Add(new ComponentAccessRequirement());
    });
});
builder.Services.AddScoped<IAuthorizationHandler, ComponentAccessHandler>();
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

builder.Services.AddMudServices();
builder.Services.AddScoped<IDialogService, DialogService>();
builder.Services.AddScoped<XpertBlazorContext>();
builder.Services.AddScoped<GlobalItems>();
builder.Services.AddScoped<SelectedItem>();
builder.Services.AddScoped<ListItem>();
builder.Services.AddScoped<ComboSelectListItem>();
builder.Services.AddScoped<ApiClient>();
builder.Services.AddScoped<PageHistoryState>();
builder.Services.AddScoped<ConfirmationDialog>();

// register Xpert Managers
builder.Services.AddManagers();
builder.Services.AddScoped<IHttpService, HttpService>();

//builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();
//uncomment below code if web api is deployed to other server than client
//if below code is commented then web api and client is supposed to be deployed on same server and same url
//builder.Services.AddScoped(x => {
//    var apiUrl = new Uri("http://localhost:5011");
//    return new HttpClient() { BaseAddress = apiUrl };
//});
//SetConnection();
builder.Services.AddSingleton<PageHistoryState>();
//update assembly in domain layer
DomainLayerData.BlazorUIAssemblyName = Assembly.GetExecutingAssembly().FullName;
DomainLayerData.BlazorUIAssemblyFilePath = Assembly.GetExecutingAssembly().Location;
await builder.Build().RunAsync();