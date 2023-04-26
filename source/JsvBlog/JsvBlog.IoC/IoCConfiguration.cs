using JsvBlog.Business.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsvBlog.IoC
{
    public static class IoCConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            Configure(services, JsvBlog.Business.IoC.Module.GetTypes());
            Configure(services, JsvBlog.Data.IoC.Module.GetTypes());
        }
        private static void Configure(IServiceCollection services, Dictionary<Type, Type> types)
        {
            foreach (var type in types)
            {
                services.AddScoped(type.Key, type.Value);
            }
        }
    }
}
