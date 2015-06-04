using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace OpenClosed

{
    public class OrderItem
    {
        public string Identifier { get; set; }
        public int Quantity { get; set; }
    }
    public enum PaymentMethod
    {
        CreditCard
        , Cheque
    }
}
