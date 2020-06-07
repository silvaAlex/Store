using Store.Domain.Entities;
using Store.Domain.Interfaces;
using Store.Domain.Interfaces.Services;
using Store.Infra.Cross.DTO.Models;
using System.Collections.Generic;

namespace Store.Application.Services
{
    public class CategoryAppService : BaseAppService<Category, CategoryDTO>, ICategoryAppService
    {
        readonly ICategoryRepository categoryRepository;

        public CategoryAppService(ICategoryRepository repository) : base(repository)
        {
            categoryRepository = repository;
        }

        public IEnumerable<CategoryDTO> GetAllActive()
        {
            return categoryRepository.GetAllActive();
        }
    }
}
