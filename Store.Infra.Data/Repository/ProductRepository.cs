using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using Store.Infra.Data.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Store.Infra.Data.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StoreContext storeContext) : base(storeContext) { }

        public IEnumerable<Product> GetActiveByCategory(int categoryId)
        {
            var activeProducts = GetAll().Where(c => c.Active && c.CategoryId.Equals(categoryId)).AsNoTracking().ToList();
            return activeProducts;
        }

        public IEnumerable<Product> GetAllActives()
        {
            var activeProducts = GetAll().Where(c => c.Active).AsNoTracking().ToList();
            return activeProducts;
        }
    }
}