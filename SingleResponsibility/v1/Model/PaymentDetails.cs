using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.v1.Model
{
    public class PaymentDetails
    {
        public PaymentMethod PaymentMethod { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CardholderName { get; set; }
    }
}
