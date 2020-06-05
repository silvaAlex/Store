using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using Store.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Store.Domain.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepository) : base(productRepository) {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> GetActiveByCategory(int categoryId)
        {
           return productRepository.GetActiveByCategory(categoryId);
        }

        public IEnumerable<Product> GetAllActives()
        {
            return productRepository.GetAllActives();
        }
    }
}
