using Store.Domain.Entities;
using System.Collections.Generic;

namespace Store.Domain.Interfaces.Services
{
    public interface IProductService : IBaseService<Product>
    {
        IEnumerable<Product> GetAllActives();
        IEnumerable<Product> GetActiveByCategory(int categoryId);
    }
}
