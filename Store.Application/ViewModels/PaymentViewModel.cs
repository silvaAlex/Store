using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Store.Application.ViewModels
{
    public class PaymentViewModel
    {
        [Key]
        public int ID { get; set; }
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Pagamento")]
        [Required(ErrorMessage = "Pagamento is required.")]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
    }
}
