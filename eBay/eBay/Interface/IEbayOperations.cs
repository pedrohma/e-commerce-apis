﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBay.Interface
{
    interface IEbayOperations
    {
        // will return a JSON with all the orders for that seller
        string GetOrders();
    }
}
