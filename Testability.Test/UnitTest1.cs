using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        // methodname_condition_expectation

        //1. Isolate the class with interface
        //2. arrange precondition
        // act on method
        // search

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new OrderProcessorTests
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);

        }
    }

    public class FakeShippingCalculator : IShippingCalculator 
    { 
        public float CalculateShipping (Order order)
        {
            throw new NotImplementedException();

        }

    }

}
