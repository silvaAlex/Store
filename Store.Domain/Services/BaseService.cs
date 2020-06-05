using Store.Domain.Interfaces.Repositories;
using Store.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Domain.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        IBaseRepository<TEntity> repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity entity)
        {
            repository.Add(entity);
        }

        public void Dispose()
        {
            repository.Dispose();
        }

        public IQueryable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return GetById(id);
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }

        public void Update(TEntity entity)
        {
            repository.Update(entity);
        }
    }
}
