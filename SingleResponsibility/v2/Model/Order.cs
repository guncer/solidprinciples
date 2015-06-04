namespace SingleResponsibility.v2.Model
    {
    public abstract class Order
    {
        private readonly ShoppingCart _shoppingCart;

        public Order(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public ShoppingCart ShoppingCart
        {
            get
            {
                return _shoppingCart;
            }
        }

        public virtual void Checkout()
        {
            //add common functionality to all Checkout operations
        }
    }
}
