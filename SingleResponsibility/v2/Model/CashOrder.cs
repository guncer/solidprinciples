namespace SingleResponsibility.v2.Model
{
    class CashOrder:Order
    {
        public CashOrder(ShoppingCart shoppingCart) : base(shoppingCart)
        {
        }
    }
}
