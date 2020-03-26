using System;
using AbstractionAppDomain;
using Microsoft.Extensions.DependencyInjection;
using SomeAppDomain;

namespace TestAppDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            //NEXO
            var nexoDomainConfiguration = new Configuration();
            nexoDomainConfiguration.Configure(serviceCollection);

            var service = serviceCollection.BuildServiceProvider();

            using (var scope = service.CreateScope())
            {
                nexoDomainConfiguration.Run(scope);
            }

            using (var scope = service.CreateScope())
            {
                var warehouseService = scope.ServiceProvider.GetService<IWarehouseService>();
                warehouseService.Get(3);

                warehouseService.GetList();
            }

            Console.ReadKey(true);

            service.Dispose();
        }

        void BuildAppDomain(ServiceCollection services)
        {

        }
    }
}
