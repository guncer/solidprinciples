using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosed.v2.Model;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            IPriceStrategy priceper=new PricePerUnitStrategy();
            IPriceStrategy priceperkilo=new PricePerKilogramStrategy();
            IList<IPriceStrategy> list=new List<IPriceStrategy>();
            IEnumerable<IPriceStrategy> s = new List<IPriceStrategy>();
            list.Add(priceper);

            ShoppingCart sw=new ShoppingCart(new DefaultPriceCalculator(list));
        }
    }
}
