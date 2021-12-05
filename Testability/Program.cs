using System;

namespace Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(); // create new order processor class

            var order = new OrderedParallelQuery { DatePlaced = DateTime.Now, TotalPrice = 100f };

            orderProcessor.Process(order);
        }
    }
}