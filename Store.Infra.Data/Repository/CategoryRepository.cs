using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using Store.Infra.Data.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Store.Infra.Data.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(StoreContext storeContext) : base(storeContext) { }

        public IEnumerable<Category> GetAllActive()
        {
            var activeCategories = GetAll().Where(c => c.Active).AsNoTracking().ToList();
            return activeCategories;
        }
    }
}
