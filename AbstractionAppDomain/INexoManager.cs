using System;
namespace AbstractionAppDomain
{
    public interface INexoManager
    {
        void Configuration();
        void Run();

        bool GetSqlConnection();
        T GetService<T>();
    }
}
