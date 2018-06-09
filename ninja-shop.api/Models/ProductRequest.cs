using System.ComponentModel.DataAnnotations;

namespace ninja_shop.core.Models
{
    public class ProductRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public  double CurrentPrice { get; set; }
        public int RequestCount { get; set; }
    }
}