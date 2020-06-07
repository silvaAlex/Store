using Microsoft.Extensions.DependencyInjection;
using Store.Domain.Interfaces.Services;
using Store.Infra.Data.Context;
using Store.Infra.Data.Repository;
using Store.Application.Services;
using Store.Domain.Interfaces;

namespace Store.Infra.Cross.Ioc
{
    public static class DiContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            // Application
            services.AddScoped<ICategoryAppService, CategoryAppService>();
            services.AddScoped<IPaymentAppService, PaymentAppService>();
            services.AddScoped<IProductAppService, ProductAppServices>();

            // Infra - Data
            services.AddScoped<StoreContext>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

        }
    }
}
