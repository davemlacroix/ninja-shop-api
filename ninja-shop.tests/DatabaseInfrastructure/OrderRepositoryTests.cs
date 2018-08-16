using System.Collections.Generic;
using ninja_shop.api.DatabaseInfrastructure;
using ninja_shop.core.Models;
using NSubstitute;
using NUnit.Framework;
using ninja_shop.api.Services;

namespace ninja_shop.tests.DatabaseInfrastructure
{
    [TestFixture]
    public class OrderRepositoryTests
    {
        [Test]
        public void Exists_WhenMatchingOrderExists_True()
        {
            var orderList = new List<Order> {new Order {Id = 1}};
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Orders.Returns(orderList);

            var exists = new OrderRepository(dataContext ).Exists(1);

            Assert.IsTrue(exists);
        }

        [Test]
        public void Exists_WhenNoMatchingOrderExists_False()
        {
            var dataContext = Substitute.For<IDataContext>();

            var exists = new OrderRepository(dataContext).Exists(1);

            Assert.IsFalse(exists);
        }

        [Test]
        public void GetOrders__ReturnsOrders()
        {
            var orderList = new List<Order> {new Order {Id = 1}};
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Orders.Returns(orderList);

            var orders = new OrderRepository(dataContext).GetOrders();

            Assert.That(orders.Count == 1);
        }

        [Test]
        public void GetOrder_WhenExists_ReturnsOrder()
        {
            var order = new Order {Id = 1};
            var orderList = new List<Order> {order};
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Orders.Returns(orderList);

            var returnOrder = new OrderRepository(dataContext).GetOrder(1);

            Assert.AreSame(order, returnOrder);
        }

        [Test]
        public void GetOrder_WhenNoneExist_ReturnsNull()
        {
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Orders.Returns(new List<Order>());

            var returnOrder = new OrderRepository(dataContext).GetOrder(1);

            Assert.IsNull(returnOrder);
        }

        [Test]
        public void CreateOrder_ReturnsOrder()
        {
            var requestList = new List<ProductRequest>
            {
                new ProductRequest {ProductId = 1, RequestCount = 1, CurrentPrice = 1},
                new ProductRequest {ProductId = 2, RequestCount = 1, CurrentPrice = 2}
            };

            var dataContext = Substitute.For<IDataContext>();
            dataContext.Orders.Returns(new List<Order>());

            var returnOrder = new OrderRepository(dataContext).CreateOrder(1, requestList);

            Assert.AreEqual(returnOrder.CustomerId, 1);
            Assert.AreEqual(returnOrder.ProductRequests.Count, 2);
        }

        [Test]
        public void CreateOrder_WithCrazyNumbers_AddsUp()
        {
            var requestList = new List<ProductRequest>
            {
                new ProductRequest {ProductId = 1, RequestCount = 1, CurrentPrice = 1},
                new ProductRequest {ProductId = 2, RequestCount = 99, CurrentPrice = 1},
                new ProductRequest {ProductId = 3, RequestCount = 4, CurrentPrice = 2},
                new ProductRequest {ProductId = 4, RequestCount = 1, CurrentPrice = 1},
                new ProductRequest {ProductId = 5, RequestCount = 2, CurrentPrice = 3},
                new ProductRequest {ProductId = 6, RequestCount = 6, CurrentPrice = 2}
            };

            var dataContext = Substitute.For<IDataContext>();
            dataContext.Orders.Returns(new List<Order>());

            var returnOrder = new OrderRepository(dataContext).CreateOrder(1, requestList);

            Assert.AreEqual(127, returnOrder.Total);
        }
    }
}