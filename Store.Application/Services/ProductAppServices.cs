using Store.Domain.Entities;
using Store.Domain.Interfaces;
using Store.Domain.Interfaces.Services;
using Store.Infra.Cross.DTO.Models;
using System.Collections.Generic;

namespace Store.Application.Services
{
    public class ProductAppServices : BaseAppService<Product, ProductDTO>, IProductAppService
    {
        readonly IProductRepository productRepository;

        public ProductAppServices(IProductRepository repository) : base(repository)
        {
            productRepository = repository;
        }

        public IEnumerable<ProductDTO> GetActiveByCategory(int categoryId)
        {
            return productRepository.GetActiveByCategory(categoryId);
        }

        public IEnumerable<ProductDTO> GetAllActives()
        {
            return productRepository.GetAllActives();
        }
    }
}
