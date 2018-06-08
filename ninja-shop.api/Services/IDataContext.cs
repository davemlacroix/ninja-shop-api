﻿using System.Collections.Generic;
using ninja_shop.core.Models;

namespace ninja_shop.api.Services
{
    public interface IDataContext
    {
        IList<Product> Products { get; }
        IList<Order> Orders { get; }
        IList<Customer> Customers { get; }
    }
}