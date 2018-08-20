using System.Collections.Generic;
using ninja_shop.api.DatabaseInfrastructure;
using ninja_shop.core.Models;
using NSubstitute;
using NUnit.Framework;
using ninja_shop.api.Services;

namespace ninja_shop.tests.DatabaseInfrastructure
{
    [TestFixture]
    public class ProductRepositoryTests
    {
        [Test]
        public void Exists_WhenMatchingProductExists_True()
        {
            var productList = new List<Product> {new Product {Id = 1}};
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Products.Returns(productList);

            var exists = new ProductRepository(dataContext).Exists(1);

            Assert.IsTrue(exists);
        }

        [Test]
        public void Exists_WhenNoMatchingProductExists_False()
        {
            var dataContext = Substitute.For<IDataContext>();

            var exists = new ProductRepository(dataContext).Exists(1);

            Assert.IsFalse(exists);
        }

        [Test]
        public void GetProducts__ReturnsProducts()
        {
            var productList = new List<Product> {new Product {Id = 1}};
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Products.Returns(productList);

            var products = new ProductRepository(dataContext).GetProducts();

            Assert.That(products.Count == 1);
        }
        
        [Test]
        public void GetProduct_WhenExists_ReturnsProduct()
        {
            var product = new Product {Id = 1};
            var productList = new List<Product> {product};
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Products.Returns(productList);

            var returnProduct = new ProductRepository(dataContext).GetProduct(1);

            Assert.AreSame(product, returnProduct);
        }
        
        [Test]
        public void GetProduct_WhenNoneExist_ReturnsNull()
        {
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Products.Returns(new List<Product>());

            var returnProduct = new ProductRepository(dataContext).GetProduct(1);

            Assert.IsNull(returnProduct);
        }

        [Test]
        public void ProductPageExists_PageNumberLessThanZero_ReturnsFalse()
        {
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Products.Count.Returns(10);

            var pageExists = new ProductRepository(dataContext).ProductsPageExists(0, 5);

            Assert.IsFalse(pageExists);
        }

        [Test]
        public void ProductPageExists_StartofPageExceedsCount_ReturnsFalse()
        {
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Products.Count.Returns(10);

            var pageExists = new ProductRepository(dataContext).ProductsPageExists(2, 10);

            Assert.IsFalse(pageExists);
        }

        [Test]
        public void ProductPageExists_StartofPageWithinCount_ReturnsTrue()
        {
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Products.Count.Returns(10);

            var pageExists = new ProductRepository(dataContext).ProductsPageExists(2, 9);

            Assert.IsTrue(pageExists);
        }

        [Test]
        public void GetProductsPage_PageDoesNotExist_ReturnEmptyPage()
        {
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Products.Count.Returns(10);

            var products = new ProductRepository(dataContext).GetProductsPage(0, 5);

            Assert.AreEqual(products.Count, 0);
        }

        [Test]
        public void GetProductsPage_Page1Length5_ReturnFirst5Products()
        {

            var productList = new List<Product> { new Product { Id = 1 },
                                                  new Product { Id = 2 },
                                                  new Product { Id = 3 },
                                                  new Product { Id = 4 },
                                                  new Product { Id = 5 },
                                                  new Product { Id = 6 },
                                                  new Product { Id = 7 },
                                                  new Product { Id = 8 }
                                                   };
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Products.Returns(productList);

            var products = new ProductRepository(dataContext).GetProductsPage(1, 5);

            Assert.AreEqual(products[0].Id, 1);
            Assert.AreEqual(products.Count, 5);
        }

        [Test]
        public void GetProductsPage_Page2Length5_ReturnsLast3Products()
        {

            var productList = new List<Product> { new Product { Id = 1 },
                                                  new Product { Id = 2 },
                                                  new Product { Id = 3 },
                                                  new Product { Id = 4 },
                                                  new Product { Id = 5 },
                                                  new Product { Id = 6 },
                                                  new Product { Id = 7 },
                                                  new Product { Id = 8 }
                                                   };
            var dataContext = Substitute.For<IDataContext>();
            dataContext.Products.Returns(productList);

            var products = new ProductRepository(dataContext).GetProductsPage(2, 5);

            Assert.AreEqual(products[0].Id, 6);
            Assert.AreEqual(products.Count, 3);
        }

    }
}