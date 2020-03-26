using System;
using Microsoft.Extensions.DependencyInjection;

namespace TestAppDomain
{
    public class Proxy
    {
        private readonly AppDomain _appDomain;
        private readonly ServiceCollection _services;

        public Proxy(ServiceCollection services)
        {
            _services = services;

           
        }


    }
}
