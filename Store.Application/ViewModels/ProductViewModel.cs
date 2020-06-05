using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Store.Application.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ID { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome do produto")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [DisplayName("Preço")]
        [Range(0.01, 1000000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DisplayName("Categoria")]
        [Required(ErrorMessage = "Category is required.")]
        public int CategoryId { get; set; }

        public CategoryViewModel Category { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public bool Active { get; set; }
    }
}