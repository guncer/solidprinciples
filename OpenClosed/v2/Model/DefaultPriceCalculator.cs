using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.v2.Model
{
    //public class DefaultPriceCalculator : IPriceCalculator
    //{
    //    private readonly List<IPriceStrategy> _pricingRules;

    //    public DefaultPriceCalculator()
    //    {
    //        _pricingRules = new List<IPriceStrategy>();
    //        _pricingRules.Add(new PricePerKilogramStrategy());
    //        _pricingRules.Add(new PricePerUnitStrategy());
    //        _pricingRules.Add(new SpecialPriceStrategy());
    //        _pricingRules.Add(new BuyThreeGetOneFree());
    //    }

    //    public decimal CalculatePrice(OrderItem item)
    //    {
    //        return _pricingRules.First(r => r.IsMatch(item)).CalculatePrice(item);
    //    }
    //}
    public class DefaultPriceCalculator : IPriceCalculator
    {
        private readonly IEnumerable<IPriceStrategy> _priceStrategies;

        public DefaultPriceCalculator(IEnumerable<IPriceStrategy> priceStrategies)
        {
            _priceStrategies = priceStrategies;
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _priceStrategies.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
