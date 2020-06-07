using AutoMapper;
using Store.Domain.Entities;
using Store.Domain.Interfaces;
using Store.Infra.Cross.DTO.Models;
using Store.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Store.Infra.Data.Repository
{
    public class CategoryRepository : BaseRepository<Category, CategoryDTO>, ICategoryRepository
    {
        public CategoryRepository(IMapper mapper, StoreContext storeContext) : base(mapper, storeContext) { }

        public IEnumerable<CategoryDTO> GetAllActive()
        {
            var activeCategories = GetAll()
                .Where(c => c.Active)
                .ToList();

            return activeCategories;
        }
    }
}
