using System;
using System.Collections.Generic;

namespace ninja_shop.core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Total { get; set; }
        public IList<ProductRequest> ProductRequests { get; set; }
    }
}