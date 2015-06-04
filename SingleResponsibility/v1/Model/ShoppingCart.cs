using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.v1.Model
{
    public class ShoppingCart
    {
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }
    }
    public enum PaymentMethod
    {
        CreditCard
        , Cheque
    }
}
