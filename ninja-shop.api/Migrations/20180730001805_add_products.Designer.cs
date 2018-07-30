﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ninja_shop.api.DatabaseInfrastructure;

namespace ninjashop.api.Migrations
{
    [DbContext(typeof(NinjaShopContext))]
    [Migration("20180730001805_add_products")]
    partial class add_products
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ninja_shop.core.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("CCCVV")
                        .IsRequired();

                    b.Property<string>("CCExp")
                        .IsRequired();

                    b.Property<string>("CCName")
                        .IsRequired();

                    b.Property<string>("CCNumber")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Zip")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new { Id = 1, Address = "1 Main St", CCCVV = "123", CCExp = "02/15", CCName = "MasterCard", CCNumber = "123456789", Email = "ABC@Abc.com", FirstName = "Test", LastName = "Test", State = "CT", Zip = "55555" }
                    );
                });

            modelBuilder.Entity("ninja_shop.core.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<double>("Total");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ninja_shop.core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("HitPoints");

                    b.Property<string>("ImageUrl");

                    b.Property<double>("Price");

                    b.Property<string>("ProductName");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, Description = "This 4 Point shuriken was crafted with steel forged by the breath of a blue dragon located in the hills of New Jersey. Great for holding up signs on a telephone pole.", HitPoints = 2, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/124303/1298928176.png", Price = 19.0, ProductName = "4-Point Shuriken" },
                        new { Id = 2, Description = "This sword has the ability to slice and dice a tomato with the precision of a claw hammer. I wouldn't recommend going into battle with it, but it would look sweet above a fireplace.", HitPoints = 4, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/57235/ninjitsu-sword.png", Price = 32.0, ProductName = "Sword" },
                        new { Id = 3, Description = "For the ninja with tiny hands. Just because you can't hold a full sized sword doesn't mean you shouldn't have a sword.", HitPoints = 4, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/139051/025.png", Price = 8.0, ProductName = "Tanto" },
                        new { Id = 4, Description = "When a 4-point shuriken just isnt enough, the 6-point shuriken goes above and beyond the call of duty. It comes with a built-in compass in case you failed field-tracking class and got lost in the woods.", HitPoints = 3, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/110443/shuriken.png", Price = 11.0, ProductName = "6-Point Shuriken" },
                        new { Id = 5, Description = "Sometimes 1 shuriken just isn't enough. Made of high-quality polyester, these shurikens will iron on to your pajamas with ease. After ironing them on, all of your enemies will fear your choice in fashion.", HitPoints = 4, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/8182/carlitos-Shurikens.png", Price = 35.0, ProductName = "3-Pack of Shurikens" },
                        new { Id = 6, Description = "Has another crew challenged you? This crew is ready for any break-dance battle or classic game of hide-and-seek. Act now, supplies are limited!", HitPoints = 777, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/23610/StudioFibonacci-Cartoon-ninjas.png", Price = 35.0, ProductName = "Your Own Ninja Crew" },
                        new { Id = 7, Description = "Hungry from all of your ninja adventures? This Pretzel Ninja will be the perfect snack to give you the energy to get back to your ninja activities!", HitPoints = 1, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/248493/Pretzel-Ninja-Leap.png", Price = 4.0, ProductName = "Pretzel Ninja Snack" },
                        new { Id = 8, Description = "Looking to recruit new ninja for your crew? This poster fits perfectly on any telephone poll. We recommend using the 4-Point Shurikens to attach them for maximum recruiting impact.", HitPoints = 1, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/222630/request-Character-1-NINJA-2015071432.png", Price = 7.0, ProductName = "Wanted Poster" },
                        new { Id = 9, Description = "The only equipment you need to start mastering the art of Nunchaku today!", HitPoints = 3, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/254907/nunchaku_by_Juhele.png", Price = 12.0, ProductName = "Nunchucks" },
                        new { Id = 10, Description = "This highly durable quick-dry cloak is the perfect way to up your game at midnight hide-and-seek game.", HitPoints = 4, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/283311/cloak.png", Price = 19.0, ProductName = "Ninja Cloak" },
                        new { Id = 11, Description = "Not just any sword. The Katana is the ultimate collectors sword for the most dedicated of ninja. Worthy to be hung over the finest fireplace mantles.", HitPoints = 10, ImageUrl = "https://openclipart.org/image/300px/svg_to_png/12874/Anonymous-katana.png", Price = 48.0, ProductName = "Katana" }
                    );
                });

            modelBuilder.Entity("ninja_shop.core.Models.ProductRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CurrentPrice");

                    b.Property<int?>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("RequestCount");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("ProductRequests");
                });

            modelBuilder.Entity("ninja_shop.core.Models.ProductRequest", b =>
                {
                    b.HasOne("ninja_shop.core.Models.Order")
                        .WithMany("ProductRequests")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
