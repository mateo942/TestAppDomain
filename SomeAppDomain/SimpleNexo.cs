using System;
using System.Threading.Tasks;
using AbstractionAppDomain;

namespace SomeAppDomain
{
    public class SimpleNexo : INexoManager
    {
        private readonly NexoSettings _nexoSettings;

        public SimpleNexo(NexoSettings nexoSettings)
        {
            _nexoSettings = nexoSettings;
        }

        public void Configuration()
        {
            Task.Delay(500);
        }

        public T GetService<T>()
        {
            return default(T);
        }

        public bool GetSqlConnection()
        {
            return true;
        }

        public void Run()
        {
            Console.WriteLine("Starting...");
            Task.Delay(1000);
            Console.WriteLine("Started");
        }
    }
}
