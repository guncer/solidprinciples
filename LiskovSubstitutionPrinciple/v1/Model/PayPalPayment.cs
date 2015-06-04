using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitutionPrinciple.v1.Services;

namespace LiskovSubstitutionPrinciple.v1.Model
{
    public class PayPalPayment : PaymentBase
    {
        public string AccountName { get; set; }
        public string Password { get; set; }

        public override string Refund(decimal amount, string transactionId)
        {
            PayPalWebService payPalWebService = new PayPalWebService();
            string token = payPalWebService.GetTransactionToken(AccountName, Password);
            string response = payPalWebService.MakeRefund(amount, transactionId, token);
            return response;
        }
    }
}
