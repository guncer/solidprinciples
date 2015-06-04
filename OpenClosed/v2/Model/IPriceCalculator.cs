using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.v2.Model
{
 public   interface IPriceCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
