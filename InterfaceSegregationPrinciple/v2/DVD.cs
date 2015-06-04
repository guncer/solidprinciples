using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.v2
{
    public class DVD : IProduct, IMovie
    {
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int RunningTime { get; set; }
    }
}
