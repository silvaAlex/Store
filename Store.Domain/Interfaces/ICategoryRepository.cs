using Store.Domain.Entities;
using System.Collections.Generic;

namespace Store.Domain.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetAllActive();
    }
}
