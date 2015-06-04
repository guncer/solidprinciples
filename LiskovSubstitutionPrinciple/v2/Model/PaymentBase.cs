using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.v2.Model
{
    public abstract class PaymentBase
    {
        public abstract bool Refund(decimal amount, string transactionId);
    }
}
