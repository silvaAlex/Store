using AutoMapper;

namespace Store.Application.AutoMapper
{
    public static class ConfigureMap
    {
        public static void Configure()
        {
            new MapperConfiguration(cfg => cfg.AddProfile<ViewModelToDomainMappingProfile>());
        }
    }
}
