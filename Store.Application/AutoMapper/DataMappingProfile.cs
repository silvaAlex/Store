using AutoMapper;
using Store.Application.ViewModels;
using Store.Domain.Entities;
using Store.Infra.Cross.DTO.Models;

namespace Store.Application.AutoMapper
{
    public class DataMappingProfile: Profile
    {
        public DataMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Payment, PaymentDTO>().ReverseMap();
        }
    }
}
