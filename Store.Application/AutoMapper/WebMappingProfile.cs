using AutoMapper;
using Store.Application.ViewModels;
using Store.Infra.Cross.DTO.Models;

namespace Store.Application.AutoMapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<CategoryDTO, CategoryViewModel>()
                .ReverseMap()
                .ForMember(dto => dto.CreatedAt, opt => opt.Ignore());

            CreateMap<ProductDTO, ProductViewModel>()
                .ReverseMap()
                .ForMember(dto => dto.CreatedAt, opt => opt.Ignore()); ;

            CreateMap<PaymentDTO, PaymentViewModel>()
                .ReverseMap()
                .ForMember(dto => dto.CreatedAt, opt => opt.Ignore()); ;
        }
    }
}
