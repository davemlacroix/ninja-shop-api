using ninja_shop.core.Models;
using Microsoft.EntityFrameworkCore;

namespace ninja_shop.api.DatabaseInfrastructure
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().HasData(
                    new Customer
                    {
                        Id = 1,
                        FirstName = "Test",
                        LastName = "Test",
                        Email = "ABC@Abc.com",
                        Address = "1 Main St",
                        State = "CT",
                        Zip = "55555",
                        CCName = "MasterCard",
                        CCNumber = "123456789",
                        CCExp = "02/15",
                        CCCVV = "123"
                    }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        ProductName = "4-Point Shuriken",
                        Description =
                            "This 4 Point shuriken was crafted with steel forged by the breath of a blue dragon located in the hills of New Jersey. Great for holding up signs on a telephone pole.",
                        HitPoints = 2,
                        Price = 19,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/124303/1298928176.png"
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "Sword",
                        Description = "This sword has the ability to slice and dice a tomato with the precision of a claw hammer. I wouldn't recommend going into battle with it, but it would look sweet above a fireplace.",
                        Price = 32,
                        HitPoints = 4,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/57235/ninjitsu-sword.png"
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "Tanto",
                        Description = "For the ninja with tiny hands. Just because you can't hold a full sized sword doesn't mean you shouldn't have a sword.",
                        Price = 8,
                        HitPoints = 4,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/139051/025.png"
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "6-Point Shuriken",
                        Description = "When a 4-point shuriken just isnt enough, the 6-point shuriken goes above and beyond the call of duty. It comes with a built-in compass in case you failed field-tracking class and got lost in the woods.",
                        Price = 11,
                        HitPoints = 3,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/110443/shuriken.png"
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "3-Pack of Shurikens",
                        Description = "Sometimes 1 shuriken just isn't enough. Made of high-quality polyester, these shurikens will iron on to your pajamas with ease. After ironing them on, all of your enemies will fear your choice in fashion.",
                        Price = 35,
                        HitPoints = 4,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/8182/carlitos-Shurikens.png"
                    },
                    new Product
                    {
                        Id = 6,
                        ProductName = "Your Own Ninja Crew",
                        Description = "Has another crew challenged you? This crew is ready for any break-dance battle or classic game of hide-and-seek. Act now, supplies are limited!",
                        Price = 35,
                        HitPoints = 777,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/23610/StudioFibonacci-Cartoon-ninjas.png"
                    },
                    new Product
                    {
                        Id = 7,
                        ProductName = "Pretzel Ninja Snack",
                        Description = "Hungry from all of your ninja adventures? This Pretzel Ninja will be the perfect snack to give you the energy to get back to your ninja activities!",
                        Price = 4,
                        HitPoints = 1,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/248493/Pretzel-Ninja-Leap.png"
                    },
                    new Product
                    {
                        Id = 8,
                        ProductName = "Wanted Poster",
                        Description = "Looking to recruit new ninja for your crew? This poster fits perfectly on any telephone poll. We recommend using the 4-Point Shurikens to attach them for maximum recruiting impact.",
                        Price = 7,
                        HitPoints = 1,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/222630/request-Character-1-NINJA-2015071432.png"
                    },
                    new Product
                    {
                        Id = 9,
                        ProductName = "Nunchucks",
                        Description = "The only equipment you need to start mastering the art of Nunchaku today!",
                        Price = 12,
                        HitPoints = 3,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/254907/nunchaku_by_Juhele.png"
                    },
                    new Product
                    {
                        Id = 10,
                        ProductName = "Ninja Cloak",
                        Description = "This highly durable quick-dry cloak is the perfect way to up your game at midnight hide-and-seek game.",
                        Price = 19,
                        HitPoints = 4,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/283311/cloak.png"
                    },
                    new Product
                    {
                        Id = 11,
                        ProductName = "Katana",
                        Description = "Not just any sword. The Katana is the ultimate collectors sword for the most dedicated of ninja. Worthy to be hung over the finest fireplace mantles.",
                        Price = 48,
                        HitPoints = 10,
                        ImageUrl = "https://openclipart.org/image/300px/svg_to_png/12874/Anonymous-katana.png"
                    }
                );
        }
    }
}