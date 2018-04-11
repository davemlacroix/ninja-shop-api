namespace ninja_shop.core.Models
{
    public class ProductRequest
    {
        public int ProductId { get; set; }
        public  double CurrentPrice { get; set; }
        public int RequestCount { get; set; }
    }
}