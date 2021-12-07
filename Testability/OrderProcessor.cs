using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator; // pass the calculator class from outside
        // make interface here

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator; // init the outside ship calculator class
           
        }


        // Unit test for process
        public void Process (Order order)
        {
            if (order.IsShipped) // order method return bool
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment;
            {
                Cost = _shippingCalculator.CalculateShipping(order); // use method in outside calculator to get cost
                ShippingDate = DateTime.Today.AddDays(1);
            }
        }
    }
}
