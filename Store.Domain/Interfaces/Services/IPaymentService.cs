using Store.Domain.Entities;
using System.Collections.Generic;

namespace Store.Domain.Interfaces.Services
{
    public interface IPaymentService : IBaseService<Payment>
    {
        IEnumerable<Payment> GetAllActives();
    }
}
