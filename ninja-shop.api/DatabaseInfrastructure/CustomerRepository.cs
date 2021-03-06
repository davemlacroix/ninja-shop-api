﻿using ninja_shop.api.Services;
using ninja_shop.core.Models;
using System.Collections.Generic;
using System.Linq;


namespace ninja_shop.api.DatabaseInfrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDataContext _dataContext;
        private readonly NinjaShopContext _context;

        public CustomerRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool Exists(int customerId)
        {
            return _dataContext.Customers.Any(x => x.Id == customerId);
        }

        public IList<Order> GetOrders(int customerId)
        {
            return _dataContext.Orders.Where(x => x.CustomerId == customerId).ToList();
        }

        public Customer GetCustomer(int customerId)
        {
            return _dataContext.Customers.SingleOrDefault(x => x.Id == customerId);
        }

        public Customer CreateCustomer(Customer customer)
        {
            _dataContext.AddCustomer(customer);
            return customer;
        }

        public IList<Customer> GetCustomers()
        {
            return _dataContext.Customers;
        }
    }
}
