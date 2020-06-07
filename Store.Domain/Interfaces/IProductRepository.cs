using Store.Domain.Entities;
using Store.Infra.Cross.DTO.Models;
using System.Collections.Generic;

namespace Store.Domain.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product,ProductDTO>
    {
        IEnumerable<ProductDTO> GetAllActives();
        IEnumerable<ProductDTO> GetActiveByCategory(int categoryId);
    }
}
