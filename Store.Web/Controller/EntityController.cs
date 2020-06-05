using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Store.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Store.Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController<TService, TEntity, TEntityViewModel>  : ControllerBase 
        where TService: IBaseService<TEntity>
        where TEntity: class
        where TEntityViewModel: class
    {
        readonly TService service;
        protected IMapper mapper;
      

        public EntityController(TService service)
        {
            this.service = service;  
        }

     
    }
}