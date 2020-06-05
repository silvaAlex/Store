using Store.Domain.Entities;
using System.Collections.Generic;

namespace Store.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        IEnumerable<Product> GetAllActives();
        IEnumerable<Product> GetActiveByCategory(int categoryId);
    }
}
