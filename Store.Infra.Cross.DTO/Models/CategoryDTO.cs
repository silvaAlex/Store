using Store.Infra.Cross.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Infra.Cross.DTO.Models
{
    public class CategoryDTO : IEntityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<ProductDTO> Products { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
