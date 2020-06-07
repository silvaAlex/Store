using System.Collections.Generic;

namespace Store.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get;  set; }
        public string Description { get;  set; }
        public virtual IEnumerable<Product> Products { get;  set; }
    }
}