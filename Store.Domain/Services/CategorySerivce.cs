using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using Store.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Store.Domain.Services
{
    public class CategorySerivce : BaseService<Category> , ICategoryService
    {
        readonly ICategoryRepository categoryRepository;

        public CategorySerivce(ICategoryRepository categoryRepository) : base (categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllActive()
        {
            return categoryRepository.GetAllActive();
        }
    }
}
