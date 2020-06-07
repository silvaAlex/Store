using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Store.Application.ViewModels;
using Store.Domain.Interfaces.Services;

namespace Store.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly ICategoryAppService categoryService;
        readonly IMapper mapper;

        public CategoryController(ICategoryAppService categoryService, IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
        }

        // GET: /category
        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            var allCategories = categoryService.GetAll();
            var mappedProducts = allCategories.ProjectTo<CategoryViewModel>(mapper.ConfigurationProvider);

            return Ok(mappedProducts);
        }

        // GET: /category/1
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Index(int id)
        {
            var mappedCategory = mapper.Map<CategoryViewModel>(categoryService.GetById(id));

            if (mappedCategory == null)
            {
                return BadRequest($"Product not  with id ${id}found");
            }

            return Ok(mappedCategory);
        }
    }
}