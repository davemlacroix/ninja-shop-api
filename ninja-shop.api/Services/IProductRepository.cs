using System.Collections.Generic;
using ninja_shop.core.Models;

namespace ninja_shop.api.Services
{
    public interface IProductRepository
    {
        bool Exists(int productId);
        Product GetProduct(int productId);
        IList<Product> GetProducts();
    }
}