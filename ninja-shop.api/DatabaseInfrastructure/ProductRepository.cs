using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ninja_shop.api.Services;
using ninja_shop.core.Models;

namespace ninja_shop.api.DatabaseInfrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataContext _dataContext;

        public ProductRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool Exists(int productId)
        {
            return _dataContext.Products.Any(x => x.Id == productId);
        }

        public Product GetProduct(int productId)
        {
            return _dataContext.Products.SingleOrDefault(x => x.Id == productId);
        }

        public IList<Product> GetProducts()
        {
            return _dataContext.Products;
        }

        public bool ProductsPageExists(int pageNumber, int pageSize)
        {
            if (pageNumber < 1 ||
                GetStartIndex(pageNumber, pageSize) >= _dataContext.Products.Count)
            {
                return false;
            }

            return true;
        }

        public IList<Product> GetProductsPage(int pageNumber, int pageSize)
        {
            if (!ProductsPageExists(pageNumber, pageSize))
            {
                return new List<Product>();
            }

            var startIndex = GetStartIndex(pageNumber, pageSize);
            var numberOfProducts = GetNumberOfProducts(pageNumber, pageSize);

            return _dataContext.Products.ToList().GetRange(startIndex, numberOfProducts);
        }

        private int GetNumberOfProducts(int pageNumber, int pageSize)
        {
            var numberOfProducts = pageSize;
            var difference =  (pageNumber * pageSize) - _dataContext.Products.Count;
            if (difference > 0)
            {
                numberOfProducts -= difference;
            }

            return numberOfProducts;
        }

        private int GetStartIndex(int pageNumber, int pageSize)
        {
            return (pageNumber - 1) * pageSize;
        }

    }
}