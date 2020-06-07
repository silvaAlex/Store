using Store.Infra.Cross.DTO.Interfaces;
using System.Linq;

namespace Store.Domain.Interfaces.Services
{
    public interface IBaseAppService<TEntityDTO> 
        where TEntityDTO : IEntityDTO
    {
        void Add(TEntityDTO entity);
        TEntityDTO GetById(int id);
        IQueryable<TEntityDTO> GetAll();
        void Update(TEntityDTO entity);
        void Remove(int id);
        void Dispose();
    }
}
