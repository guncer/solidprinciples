
using SingleResponsibility.v2.Model;

namespace SingleResponsibility.v2.Services
{
   public interface INotificationService
    {
        void NotifyCustomerOrderCreated(ShoppingCart cart);
    }
}
