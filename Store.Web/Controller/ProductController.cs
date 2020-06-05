using Microsoft.AspNetCore.Mvc;
using Store.Application.ViewModels;
using Store.Domain.Entities;
using Store.Domain.Interfaces.Services;

namespace Store.Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : EntityController<IProductService, Product, ProductViewModel>
    {
        readonly IProductService productService;

        public ProductController(IProductService service) : base(service)
        {
            productService = service;
        }

        // GET: product/1
        public ActionResult<ProductViewModel> Index(int id)
        {
            var product = productService.GetById(id);
            var mappedProduct = mapper.Map<ProductViewModel>(product);

            return mappedProduct;
        }
    }
}