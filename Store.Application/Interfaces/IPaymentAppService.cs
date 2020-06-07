using Store.Infra.Cross.DTO.Models;
using System.Collections.Generic;

namespace Store.Domain.Interfaces.Services
{
    public interface IPaymentAppService : IBaseAppService<PaymentDTO>
    {
        IEnumerable<PaymentDTO> GetAllActives();
    }
}
