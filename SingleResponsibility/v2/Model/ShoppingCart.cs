using System.Collections.Generic;

namespace SingleResponsibility.v2.Model
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
