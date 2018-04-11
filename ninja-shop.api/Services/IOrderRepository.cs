using System.Collections.Generic;
using ninja_shop.core.Models;

namespace ninja_shop.api.Services
{
    public interface IOrderRepository
    {
        bool Exists(int orderId);
        Order GetOrder(int orderId);
        IList<Order> GetOrders();
        Order CreateOrder(int customerId, IList<ProductRequest> productRequests);
    }
}