using System;
using AbstractionAppDomain;

namespace SomeAppDomain
{
    public class WarehouseService : IWarehouseService
    {
        private readonly INexoManager _nexoManager;

        public WarehouseService(INexoManager nexoManager)
        {
            _nexoManager = nexoManager;
        }

        public void Get(int id)
        {
            var service = _nexoManager.GetService<decimal>();

            Console.WriteLine("Get by id");
        }

        public void GetList()
        {
            var service = _nexoManager.GetService<double>();

            Console.WriteLine("Get list");
        }
    }
}
