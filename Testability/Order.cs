using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    public class Order
    {
        private int _isShipped;
        private float _totalPrice;
        private DateTime _orderTime;
    }

    public Order(int IsShipped, DateTime OrderTime, float TotalPrice)
    {
        this._isShipped = new IsShipped();
        _taotalPrice = new TotalPrice;
        _ordertime = OrderTime;

    }
}
