using System;

namespace Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(); // create new order processor class

            var order = new Order { bool IsShipped = true; DateTime  DatePlaced = DateTime.Now; float TotalPrice = 100f };

            orderProcessor.Process(order);
        }
    }
}