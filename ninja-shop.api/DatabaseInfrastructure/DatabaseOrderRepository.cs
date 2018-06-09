using System.Collections.Generic;
using System.Linq;
using ninja_shop.api.Services;
using ninja_shop.core.Models;
using ninja_shop.api.DatabaseInfrastructure;

namespace ninja_shop.api.DatabaseInfrastructure
{
    public class DatabaseOrderRepository : IOrderRepository
    {
        private readonly IDataContext _dataContext;

        public DatabaseOrderRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool Exists(int orderId)
        {
            return _dataContext.Orders.Any(x => x.Id == orderId);
        }

        public Order GetOrder(int orderId)
        {
            return _dataContext.Orders.SingleOrDefault(x => x.Id == orderId);
        }

        public IList<Order> GetOrders()
        {
            return _dataContext.Orders;
        }

        public Order CreateOrder(int customerId, IList<ProductRequest> productRequests)
        {
            var order = new Order();
            order.CustomerId = customerId;
            order.ProductRequests = productRequests;
            order.Total = productRequests.Sum(x => x.CurrentPrice * x.RequestCount);

            using (var context = new NinjaShopContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
            return order;
        }
    }
}