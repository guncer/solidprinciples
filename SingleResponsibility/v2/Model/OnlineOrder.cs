

using SingleResponsibility.v2.Services;

namespace SingleResponsibility.v2.Model
{
   public class OnlineOrder:Order
    {
        private readonly INotificationService _notificationService;
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentService _paymentService;
        private readonly IReservationService _reservationService;
       public OnlineOrder(ShoppingCart shoppingCart,PaymentDetails paymentDetails,IPaymentService paymentService,INotificationService notificationService,IReservationService reservationService) : base(shoppingCart)
       {
           _paymentDetails = paymentDetails;
           _paymentService = paymentService;
           _notificationService = notificationService;
           _reservationService = reservationService;
       }

       public override void Checkout()
       {
           _paymentService.ProcessCreditCard(_paymentDetails,ShoppingCart.TotalAmount);
           _reservationService.ReserveInventory(ShoppingCart.Items);
           _notificationService.NotifyCustomerOrderCreated(ShoppingCart);
           base.Checkout();
       }
    }
}
