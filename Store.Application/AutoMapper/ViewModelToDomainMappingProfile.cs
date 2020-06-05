using AutoMapper;
using Store.Application.ViewModels;
using Store.Domain.Entities;

namespace Store.Application.AutoMapper
{
    class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Category, CategoryViewModel>()
                .ReverseMap()
                .ForMember(dto => dto.CreatedAt, opt => opt.Ignore());

            CreateMap<Product, ProductViewModel>()
                .ReverseMap()
                .ForMember(dto => dto.CreatedAt, opt => opt.Ignore());

            CreateMap<Payment, PaymentViewModel>()
                .ReverseMap()
                .ForMember(dto => dto.CreatedAt, opt => opt.Ignore());
        }

    }
}
