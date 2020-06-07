using System.Collections.Generic;
using Store.Domain.Entities;
using Store.Infra.Cross.DTO.Models;

namespace Store.Domain.Interfaces
{
    public interface IPaymentRepository : IBaseRepository<Payment,PaymentDTO>
    {
        IEnumerable<PaymentDTO> GetAllActive();
    }
}
