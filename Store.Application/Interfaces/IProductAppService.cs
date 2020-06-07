﻿using Store.Infra.Cross.DTO.Models;
using System.Collections.Generic;

namespace Store.Domain.Interfaces.Services
{
    public interface IProductAppService : IBaseAppService<ProductDTO>
    {
        IEnumerable<ProductDTO> GetAllActives();
        IEnumerable<ProductDTO> GetActiveByCategory(int categoryId);
    }
}
