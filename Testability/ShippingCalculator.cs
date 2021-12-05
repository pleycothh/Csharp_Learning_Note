﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    public class ShippingCalculator
    {


        public float CalculateShipping(Order order)
        {
            if(order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            return 0;

      
        }
    }
}