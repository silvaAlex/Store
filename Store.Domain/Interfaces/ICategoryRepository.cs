using Store.Domain.Entities;
using Store.Infra.Cross.DTO.Models;
using System.Collections.Generic;

namespace Store.Domain.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category,CategoryDTO>
    {
        IEnumerable<CategoryDTO> GetAllActive();
    }
}
