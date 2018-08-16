//using System.Collections.Generic;
//using ninja_shop.core.Models;
//using ninja_shop.api.Services;

//namespace ninja_shop.api.InMemoryInfrastructure
//{
//    public sealed class InMemoryStorage : IDataContext
//    {
//        static InMemoryStorage() { }

//        InMemoryStorage() { }

//        public static InMemoryStorage Instance { get; private set; } = new InMemoryStorage();

//        public IList<Product> Products { get; } = LoadProducts();
//        public IList<Order> Orders { get; } = new List<Order>();
//        public IList<Customer> Customers { get; } = LoadCustomers();


//        private static IList<Product> LoadProducts()
//        {
//            return new List<Product>
//            {
//                new Product
//                {
//                    Id = 1,
//                    ProductName = "4-Point Shuriken",
//                    Description =
//                        "This 4 Point shuriken was crafted with steel forged by the breath of a blue dragon located in the hills of New Jersey. Great for holding up signs on a telephone pole.",
//                    HitPoints = 2,
//                    Price = 19,
//                    ImageUrl = "https://openclipart.org/image/300px/svg_to_png/124303/1298928176.png"
//                },
//                new Product
//                {
//                    Id= 2,
//                    ProductName ="Sword",
//                    Description = "This sword has the ability to slice and dice a tomato with the precision of a claw hammer. I wouldn't recommend going into battle with it, but it would look sweet above a fireplace.",
//                    Price = 32,
//                    HitPoints= 4,
//                    ImageUrl = "https://openclipart.org/image/300px/svg_to_png/57235/ninjitsu-sword.png"
//                },
//                new Product
//                {
//                    Id= 3,
//                    ProductName= "Tanto",
//                    Description= "For the ninja with tiny hands. Just because you can't hold a full sized sword doesn't mean you shouldn't have a sword.",
//                    Price= 8,
//                    HitPoints= 4,
//                    ImageUrl= "https://openclipart.org/image/300px/svg_to_png/139051/025.png"
//                },
//                new Product
//                {
//                    Id= 4,
//                    ProductName= "6-Point Shuriken",
//                    Description= "When a 4-point shuriken just isnt enough, the 6-point shuriken goes above and beyond the call of duty. It comes with a built-in compass in case you failed field-tracking class and got lost in the woods.",
//                    Price= 11,
//                    HitPoints= 3,
//                    ImageUrl= "https://openclipart.org/image/300px/svg_to_png/110443/shuriken.png"
//                },
//                new Product
//                {
//                    Id= 5,
//                    ProductName= "3-Pack of Shurikens",
//                    Description= "Sometimes 1 shuriken just isn't enough. Made of high-quality polyester, these shurikens will iron on to your pajamas with ease. After ironing them on, all of your enemies will fear your choice in fashion.",
//                    Price= 35,
//                    HitPoints= 4,
//                    ImageUrl= "https://openclipart.org/image/300px/svg_to_png/8182/carlitos-Shurikens.png"
//                },
//                new Product
//                {
//                    Id=6,
//                    ProductName= "Your Own Ninja Crew",
//                    Description= "Has another crew challenged you? This crew is ready for any break-dance battle or classic game of hide-and-seek. Act now, supplies are limited!",
//                    Price= 35,
//                    HitPoints= 777,
//                    ImageUrl= "https://openclipart.org/image/300px/svg_to_png/23610/StudioFibonacci-Cartoon-ninjas.png"
//                }
//            };
//        }


//        private static IList<Customer> LoadCustomers()
//        {
//            return new List<Customer>
//         {
//             new Customer{FirstName = "Test",LastName = "Test", Id = 1,Email = "ABC@Abc.com"}
//         };
//        }


//        public static void Reset()
//        {
//            Instance = new InMemoryStorage();
//        }
//    }
//}