using Store.Infra.Cross.DTO.Models;
using System.Collections.Generic;

namespace Store.Domain.Interfaces.Services
{
    public interface ICategoryAppService : IBaseAppService<CategoryDTO>
    {
        IEnumerable<CategoryDTO> GetAllActive();
    }
}
