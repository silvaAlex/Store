using Store.Domain.Interfaces;
using Store.Domain.Interfaces.Services;
using Store.Infra.Cross.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Application.Services
{
    public class BaseAppService<TEntity, TEntityDTO> : IDisposable ,IBaseAppService<TEntityDTO>
        where TEntity: class
        where TEntityDTO : IEntityDTO
    {
        readonly IBaseRepository<TEntity, TEntityDTO> repository;

        public BaseAppService(IBaseRepository<TEntity, TEntityDTO> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntityDTO entity)
        {
            repository.Add(entity);
        }

        public void Dispose()
        {
            repository.Dispose();
        }

        public IQueryable<TEntityDTO> GetAll()
        {
            return repository.GetAll();
        }

        public TEntityDTO GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }

        public void Update(TEntityDTO entity)
        {
            repository.Update(entity);
        }
    }
}
