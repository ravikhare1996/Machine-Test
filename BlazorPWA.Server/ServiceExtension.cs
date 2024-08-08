using BlazorPWA.Server.Controllers;
using BlazorPWA.Shared.Managers;
using GenericCrudApi.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XS.ASPNetCore.Server.Controllers;

namespace BlazorPWA.Server
{
    public static class ServiceExtension
    {
        public static void AddXpertControllers(this IServiceCollection self)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.BaseType?.IsGenericType == true)
                .Where(t => t.BaseType?.GetGenericTypeDefinition() == typeof(XpertControllerBase<>));

            foreach (var type in types)
            {
                self.AddScoped(type);
            }
            //self.AddScoped(typeof(CommonDBController));
            //self.AddScoped(typeof(MyDbController));
        }        
    }
}
