using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.v2.Model
{
    public interface IPriceStrategy
    {
        bool IsMatch(OrderItem item);
        decimal CalculatePrice(OrderItem item);
    }
}
