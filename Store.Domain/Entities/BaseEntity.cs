using System;

namespace Store.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
