using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.v1.Model
{
    public abstract class PaymentBase
    {
        public abstract string Refund(decimal amount, string transactionId);
    }
}
