using System.Linq;

namespace Store.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(int id);
        void Dispose();
    }
}
