using System.Collections.Generic;
using ninja_shop.core.Models;

namespace ninja_shop.api.Services
{
    public interface ICustomerRepository
    {
        IList<Order> GetOrders(int customerId);
        Customer GetCustomer(int customerId);
        Customer CreateCustomer(Customer customer);
        IList<Customer> GetCustomers();
        bool Exists(int customerId);
    }
}