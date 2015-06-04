using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.v1.Model
{
    public class PaymentFactory
    {
        public static PaymentBase GetPaymentService(PaymentServiceType serviceType)
        {
            switch (serviceType)
            {
                case PaymentServiceType.PayPal:
                    return new PayPalPayment();
                case PaymentServiceType.WorldPay:
                    return new WorldPayPayment();
                default:
                    throw new NotImplementedException("No such service.");
            }
        }
    }
}
