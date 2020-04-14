using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment3
{
    class Eshop
    {
        private PaymentMethod _paymentMethod;
        private IEnumerable<Variation> _variations;

        public void Variation(IEnumerable<Variation> variation)
        {
            _variations = variation;
        }

        public void SelectPaymentMethod(PaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void PayTShirt(TShirt tshirt)
        {
            foreach (var variation in _variations)
            {
                Console.WriteLine($"Applying {variation.GetType().Name}");
                variation.Cost(tshirt);
                Console.WriteLine($"TShirt cost after applying {variation.GetType().Name} is: {tshirt.Price}");
                Console.WriteLine();
            }

            _paymentMethod.Pay(tshirt.Price);
        }
    }

}
