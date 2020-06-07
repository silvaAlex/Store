using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.AutoMapper;

namespace Store.WebApi.Configuration
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DataMappingProfile), typeof(WebMappingProfile));
        }
    }
}