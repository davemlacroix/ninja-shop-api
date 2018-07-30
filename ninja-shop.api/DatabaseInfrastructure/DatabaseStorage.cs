using ninja_shop.api.Services;
using System.Collections.Generic;
using System.Linq;
using ninja_shop.core.Models;

namespace ninja_shop.api.DatabaseInfrastructure
{
    public class DatabaseStorage : IDataContext
    {
        private NinjaShopContext _context;

        public DatabaseStorage(NinjaShopContext context)
        {
            _context = context;
        }

        public IList<Product> Products => GetProducts();
        public IList<Order> Orders => GetOrders();
        public IList<Customer> Customers => GetCustomer();


        private IList<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        private IList<Customer> GetCustomer()
        {
            return _context.Customers.ToList();
        }

        private IList<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }
    }
}
