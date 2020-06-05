using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using Store.Infra.Data.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Store.Infra.Data.Repository
{
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(StoreContext storeContext) : base(storeContext) { }
    
        public IEnumerable<Payment> GetAllActive()
        {
            var activePayments = GetAll().Where(c => c.Active).AsNoTracking().ToList();
            return activePayments;
        }
    }
}
