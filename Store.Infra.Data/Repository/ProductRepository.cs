using AutoMapper;
using Store.Domain.Entities;
using Store.Domain.Interfaces;
using Store.Infra.Cross.DTO.Models;
using Store.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Store.Infra.Data.Repository
{
    public class ProductRepository : BaseRepository<Product, ProductDTO>, IProductRepository
    {
        public ProductRepository(IMapper mapper, StoreContext storeContext) : base(mapper, storeContext) { }
   
        public IEnumerable<ProductDTO> GetActiveByCategory(int categoryId)
        {
            var activeProducts = GetAll()
                .Where(x => x.Active && x.CategoryId.Equals(categoryId))
                .ToList();

            return activeProducts;
        }

        public IEnumerable<ProductDTO> GetAllActives()
        {
            var activeProducts = GetAll()
                .Where(x => x.Active)
                .ToList();

            return activeProducts;
        }
    }
}
