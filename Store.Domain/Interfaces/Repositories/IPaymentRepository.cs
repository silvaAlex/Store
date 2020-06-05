using System.Collections.Generic;
using Store.Domain.Entities;

namespace Store.Domain.Interfaces.Repositories
{
    public interface IPaymentRepository : IBaseRepository<Payment>
    {
        IEnumerable<Payment> GetAllActive();
    }
}
