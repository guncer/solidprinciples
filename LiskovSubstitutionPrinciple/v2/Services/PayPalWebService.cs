using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.v2.Services
{
    public class PayPalWebService
    {
        public string GetTransactionToken(string username, string password)
        {
            return "Hello from PayPal";
        }

        public string MakeRefund(decimal amount, string transactionId, string token)
        {
            return "Auth";
        }
    }
}
