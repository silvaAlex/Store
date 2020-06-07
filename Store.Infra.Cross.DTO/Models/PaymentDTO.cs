using Store.Infra.Cross.DTO.Interfaces;
using System;

namespace Store.Infra.Cross.DTO.Models
{
    public class PaymentDTO : IEntityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
