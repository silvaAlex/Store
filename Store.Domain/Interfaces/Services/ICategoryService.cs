using Store.Domain.Entities;
using System.Collections.Generic;

namespace Store.Domain.Interfaces.Services
{
    public interface ICategoryService : IBaseService<Category>
    {
        IEnumerable<Category> GetAllActive();
    }
}
