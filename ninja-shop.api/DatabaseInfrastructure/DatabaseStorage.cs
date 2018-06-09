using ninja_shop.api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ninja_shop.core.Models;
using ninja_shop.api.DatabaseInfrastructure;

namespace ninja_shop.api.DatabaseInfrastructure
{
    public class DatabaseStorage : IDataContext
    {

        static DatabaseStorage() { }

        DatabaseStorage() { }

        public static DatabaseStorage Instance { get; private set; } = new DatabaseStorage();

        public IList<Product> Products => GetProducts();
        public IList<Order> Orders => GetOrders();
        public IList<Customer> Customers => GetCustomer();

        private IList<Product> GetProducts()
        {
            using (var context = new NinjaShopContext())
            {
                return context.Products.ToList();
            }
        }

        private IList<Customer> GetCustomer()
        {
            using (var context = new NinjaShopContext())
            {
                return context.Customers.ToList();
            }
        }

        private IList<Order> GetOrders()
        {
            using (var context = new NinjaShopContext())
            {
                return context.Orders.ToList();
            }
        }
    }
}
