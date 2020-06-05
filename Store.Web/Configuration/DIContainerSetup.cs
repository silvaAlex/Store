using Microsoft.Extensions.DependencyInjection;
using Store.Infra.Cross.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Configuration
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
