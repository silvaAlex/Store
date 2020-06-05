using Microsoft.Extensions.DependencyInjection;
using Store.Domain.Interfaces.Repositories;
using Store.Domain.Interfaces.Services;
using Store.Domain.Services;
using Store.Infra.Data.Context;
using Store.Infra.Data.Repository;

namespace Store.Infra.Cross.Ioc
{
    public static class DiContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<StoreContext>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<ICategoryService, CategorySerivce>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
