using System;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractionAppDomain
{
    public interface IConfiguration
    {
        void Configure(IServiceCollection services);
        void Run(IServiceScope scope);
    }
}
