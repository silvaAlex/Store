using System;

namespace Store.Infra.Cross.DTO.Interfaces
{
    public interface IEntityDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
