using Store.Domain.Entities;
using System.Collections.Generic;

namespace Store.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        IEnumerable<Category> GetAllActive();
    }
}
