using System.Security.Cryptography.X509Certificates;

namespace ninja_shop.core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int HitPoints { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}