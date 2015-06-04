using System.Collections.Generic;
using SingleResponsibility.v2.Model;


namespace SingleResponsibility.v2.Services
{
   public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}
