using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitutionPrinciple.v2.Model;

namespace LiskovSubstitutionPrinciple.v2.Services
{
    public class RefundService
    {
        public bool Refund(PaymentServiceType paymentServiceType, decimal amount, string transactionId)
        {
            PaymentBase payment = PaymentFactory.GetPaymentService(paymentServiceType);
            return payment.Refund(amount, transactionId);
        }
    }
}
