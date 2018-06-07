using ninja_shop.core.Models;
using Microsoft.EntityFrameworkCore;

namespace ninja_shop.api.DataContexts
{
    public class NinjaShopContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductRequest> ProductRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = NinjaShopData; Trusted_Connection = True;");    
        }
    }
}