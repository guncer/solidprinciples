﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.v1.Model
{
    public class RefundService
    {
        public bool Refund(PaymentServiceType paymentServiceType, decimal amount, string transactionId)
        {
            bool refundSuccess = false;
            PaymentBase payment = PaymentFactory.GetPaymentService(paymentServiceType);
            if ((payment as PayPalPayment) != null)
            {
                ((PayPalPayment)payment).AccountName = "Andras";
                ((PayPalPayment)payment).Password = "Passw0rd";
            }
            else if ((payment as WorldPayPayment) != null)
            {
                ((WorldPayPayment)payment).AccountName = "Andras";
                ((WorldPayPayment)payment).Password = "Passw0rd";
                ((WorldPayPayment)payment).ProductId = "ABC";
            }

            string serviceResponse = payment.Refund(amount, transactionId);

            if (serviceResponse.Contains("Auth") || serviceResponse.Contains("Success"))
            {
                refundSuccess = true;
            }

            return refundSuccess;
        }
    }
}
