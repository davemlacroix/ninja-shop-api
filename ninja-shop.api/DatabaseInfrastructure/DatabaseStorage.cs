using ninja_shop.api.Services;
using System.Collections.Generic;
using System.Linq;
using ninja_shop.core.Models;

namespace ninja_shop.api.DatabaseInfrastructure
{
    public class DatabaseStorage : IDataContext
    {

        static DatabaseStorage() { }
        DatabaseStorage() { }

        public static NinjaShopContext Context = new NinjaShopContext();
        public static DatabaseStorage Instance { get; private set; } = new DatabaseStorage();

        public IList<Product> Products => GetProducts();
        public IList<Order> Orders => GetOrders();
        public IList<Customer> Customers => GetCustomer();

        private IList<Product> GetProducts()
        {
            return Context.Products.ToList();
        }

        private IList<Customer> GetCustomer()
        {
            return Context.Customers.ToList();
        }

        private IList<Order> GetOrders()
        {
            return Context.Orders.ToList();
        }
    }
}
