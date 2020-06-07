using Store.Infra.Cross.DTO.Interfaces;
using System;
using System.Linq;

namespace Store.Domain.Interfaces
{
    public interface IBaseRepository<TEntity, TEntityDTO> : IDisposable 
        where TEntity : class
        where TEntityDTO: IEntityDTO
    {
        void Add(TEntityDTO entity);
        TEntityDTO GetById(int id);
        IQueryable<TEntityDTO> GetAll();
        void Update(TEntityDTO entity);
        void Remove(int id);
    }
}
