using Store.Infra.Cross.DTO.Interfaces;
using System;

namespace Store.Infra.Cross.DTO.Models
{
    public class ProductDTO : IEntityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual CategoryDTO Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}