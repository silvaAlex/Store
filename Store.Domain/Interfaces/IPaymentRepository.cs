using System.Collections.Generic;
using Store.Domain.Entities;

namespace Store.Domain.Interfaces
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        IEnumerable<Payment> GetAllActive();
    }
}
