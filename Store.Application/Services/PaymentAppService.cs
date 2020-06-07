using Store.Domain.Entities;
using Store.Domain.Interfaces;
using Store.Domain.Interfaces.Services;
using Store.Infra.Cross.DTO.Models;
using System.Collections.Generic;

namespace Store.Application.Services
{
    public class PaymentAppService : BaseAppService<Payment, PaymentDTO>, IPaymentAppService
    {
        readonly IPaymentRepository paymentRepository;

        public PaymentAppService(IPaymentRepository repository) : base(repository)
        {
            paymentRepository = repository;
        }

        public IEnumerable<PaymentDTO> GetAllActives()
        {
            return paymentRepository.GetAllActive();
        }
    }
}
