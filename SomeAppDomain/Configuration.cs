using System;
using AbstractionAppDomain;
using Microsoft.Extensions.DependencyInjection;

namespace SomeAppDomain
{
    public class Configuration : IConfiguration
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<NexoSettings>();
            services.AddSingleton<INexoManager, SimpleNexo>();

            services.AddScoped<IWarehouseService, WarehouseService>();
        }

        public void Run(IServiceScope scope)
        {
            scope.ServiceProvider.GetService<INexoManager>().Run();
        }
    }
}
