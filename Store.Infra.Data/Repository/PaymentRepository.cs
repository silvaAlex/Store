using AutoMapper;
using Store.Domain.Entities;
using Store.Domain.Interfaces;
using Store.Infra.Cross.DTO.Models;
using Store.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Store.Infra.Data.Repository
{
    public class PaymentRepository : BaseRepository<Payment, PaymentDTO>, IPaymentRepository
    {
        public PaymentRepository(IMapper mapper, StoreContext storeContext) : base(mapper, storeContext) { }

        public IEnumerable<PaymentDTO> GetAllActive()
        {
            var activePayments = GetAll()
                .Where(x => x.Active)
                .ToList();
            return activePayments;
        }
    }
}
