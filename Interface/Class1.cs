using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    static class Program1
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();
            var order = new OrderedParallelQuery { DataPlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
