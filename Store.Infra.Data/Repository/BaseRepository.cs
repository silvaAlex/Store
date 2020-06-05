using Microsoft.EntityFrameworkCore;
using Store.Domain.Interfaces.Repositories;
using Store.Infra.Data.Context;
using System;
using System.Linq;

namespace Store.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly StoreContext StoreContext;
        protected readonly DbSet<TEntity> Entities;

        public BaseRepository(StoreContext storeContext)
        {
            StoreContext = storeContext;
            Entities = storeContext.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            Entities.Add(entity);
        }

        public virtual void Dispose()
        {
            StoreContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return Entities;
        }

        public virtual TEntity GetById(int id)
        {
            return Entities.Find(id);
        }

        public virtual void Remove(int id)
        {
            Entities.Remove(GetById(id));
        }

        public virtual int SaveChanges()
        {
            return StoreContext.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            Entities.Update(entity);
        }
    }
}
