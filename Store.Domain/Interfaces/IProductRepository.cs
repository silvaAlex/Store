using Store.Domain.Entities;
using System.Collections.Generic;

namespace Store.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAllActives();
        IEnumerable<Product> GetActiveByCategory(int categoryId);
    }
}
