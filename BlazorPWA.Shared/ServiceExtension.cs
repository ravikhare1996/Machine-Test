using BlazorPWA.Shared.Managers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XpertStudio.Common.Managers;

namespace BlazorPWA.Shared
{
    public static class ServiceExtension
    {
        public static void AddManagers(this IServiceCollection self)
        {
            //var tp=typeof(CoolieManager).GetInterfaces().FirstOrDefault().Name;
            var types = Assembly.GetExecutingAssembly().DefinedTypes.Where(t => typeof(IManager).IsAssignableFrom(t) == true);
            // .Where(t => t.BaseType?.GetGenericTypeDefinition() == typeof(XpertControllerBase<>));
            foreach (var type in types)
            {
                if (type.GetInterface(typeof(IManager).Name.ToString()) != null)
                {
                    var rep = types.Where(o => type.IsAssignableFrom(o) && o != type).FirstOrDefault();
                    if (rep != null)
                    {
                        self.AddScoped(type, rep);
                    }
                }
            }
            //self.AddScoped<ITrainManager,TrainManager>();
            //self.AddScoped<ICoolieManager, CoolieManager>();
            //self.AddScoped<IStationManager, StationManager>();
        }
    }
}
