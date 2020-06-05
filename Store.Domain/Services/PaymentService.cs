using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using Store.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Services
{
    public class PaymentService : BaseService<Payment> , IPaymentService
    {
        readonly IPaymentRepository paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository) : base(paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }

        public IEnumerable<Payment> GetAllActives()
        {
            return paymentRepository.GetAllActive();
        }
    }
}
