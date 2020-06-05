using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Store.Application.ViewModels
{
    public class CategoryViewModel
    {
        [Key]
        public int ID { get; set; }
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome da categoria")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [MinLength(2)]
        [MaxLength(255)]
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
        public virtual IEnumerable<ProductViewModel> Products { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
