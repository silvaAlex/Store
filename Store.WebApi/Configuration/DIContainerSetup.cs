using Microsoft.Extensions.DependencyInjection;
using Store.Infra.Cross.Ioc;
using System;

namespace Store.WebApi.Configuration
{
    public static class DIContainerSetup
    {
        public static void AddDIContainerSetup(this IServiceCollection services)
        {
            if(services == null) 
                throw new ArgumentNullException(nameof(services));

            DiContainer.RegisterDependencies(services);
        }
    }
}
