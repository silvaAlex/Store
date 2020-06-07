using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Store.Application.ViewModels;
using Store.Domain.Interfaces.Services;
using Store.Infra.Cross.DTO.Models;
using System;
using System.Collections.Generic;

namespace Store.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductAppService productService;
        readonly IMapper mapper;

        public ProductController(IProductAppService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;

        }

        // GET: /product
        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            var allProducts = productService.GetAll();

            var mappedProducts = mapper.Map<List<ProductViewModel>>(allProducts);

            return Ok(mappedProducts);
        }

        // GET: /product/category/1
        [HttpGet]
        [Route("category/{categoryId:int}")]
        public IActionResult GetByCategoty(int categoryId)
        {
            var allProducts = productService.GetActiveByCategory(categoryId);
            var mappedProducts = mapper.Map<List<ProductViewModel>>(allProducts);

            return Ok(mappedProducts);
        }

        // GET: /product/1
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Index(int id)
        {
            var mappedProduct = mapper.Map<ProductViewModel>(productService.GetById(id));

            if (mappedProduct == null)
            {
                return BadRequest($"Product not  with id ${id}found");
            }

            return Ok(mappedProduct);
        }

        // POST: /product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual IActionResult Post(ProductViewModel entity)
        {
            if (ModelState.IsValid)
            {
                var mappedEntity = mapper.Map<ProductDTO>(entity);
                mappedEntity.CreatedAt = DateTime.Now;
                productService.Add(mappedEntity);

                return Ok(mappedEntity);
            }

            return BadRequest("error model invalid");
        }

        // POST: /product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductViewModel entity)
        {
            if (ModelState.IsValid)
            {
                var mappedEntity = mapper.Map<ProductDTO>(entity);
                productService.Update(mappedEntity);
                return Ok(mappedEntity);
            }

            return BadRequest("error model invalid");
        }

        // POST: entity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual IActionResult DeleteConfirmed(int id)
        {
            productService.Remove(id);
            return Ok();
        }
    }
}