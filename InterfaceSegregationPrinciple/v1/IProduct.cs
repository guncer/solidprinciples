using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.v1
{
    public interface IProduct
    {
        decimal Price { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
        int AgeLimit { get; set; }
        int RunningTime { get; set; }
    }
}
