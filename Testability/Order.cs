using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    public class Order
    {
        public int IsShipped;
        public float TotalPrice;
        public DateTime OrderTime;



        public Order(int IsShipped, DateTime OrderTime, float TotalPrice)
        {
            IsShipped = IsShipped;
            TotalPrice = TotalPrice;
            OrderTime = OrderTime;

        }
    }
}
