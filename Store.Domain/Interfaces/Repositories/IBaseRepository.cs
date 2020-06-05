using System;
using System.Linq;

namespace Store.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(int id);
        int SaveChanges();
    }
}
