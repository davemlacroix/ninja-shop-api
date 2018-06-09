using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ninjashop.api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(nullable: false),
                    CCName = table.Column<string>(nullable: false),
                    CCNumber = table.Column<string>(nullable: false),
                    CCExp = table.Column<string>(nullable: false),
                    CCCVV = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HitPoints = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    CurrentPrice = table.Column<double>(nullable: false),
                    RequestCount = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRequests_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CCCVV", "CCExp", "CCName", "CCNumber", "Email", "FirstName", "LastName", "State", "Zip" },
                values: new object[] { 1, "1 Main St", "123", "02/15", "MasterCard", "123456789", "ABC@Abc.com", "Test", "Test", "CT", "55555" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "HitPoints", "ImageUrl", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "This 4 Point shuriken was crafted with steel forged by the breath of a blue dragon located in the hills of New Jersey. Great for holding up signs on a telephone pole.", 2, "https://openclipart.org/image/300px/svg_to_png/124303/1298928176.png", 19.0, "4-Point Shuriken" },
                    { 2, "This sword has the ability to slice and dice a tomato with the precision of a claw hammer. I wouldn't recommend going into battle with it, but it would look sweet above a fireplace.", 4, "https://openclipart.org/image/300px/svg_to_png/57235/ninjitsu-sword.png", 32.0, "Sword" },
                    { 3, "For the ninja with tiny hands. Just because you can't hold a full sized sword doesn't mean you shouldn't have a sword.", 4, "https://openclipart.org/image/300px/svg_to_png/139051/025.png", 8.0, "Tanto" },
                    { 4, "When a 4-point shuriken just isnt enough, the 6-point shuriken goes above and beyond the call of duty. It comes with a built-in compass in case you failed field-tracking class and got lost in the woods.", 3, "https://openclipart.org/image/300px/svg_to_png/110443/shuriken.png", 11.0, "6-Point Shuriken" },
                    { 5, "Sometimes 1 shuriken just isn't enough. Made of high-quality polyester, these shurikens will iron on to your pajamas with ease. After ironing them on, all of your enemies will fear your choice in fashion.", 4, "https://openclipart.org/image/300px/svg_to_png/8182/carlitos-Shurikens.png", 35.0, "3-Pack of Shurikens" },
                    { 6, "Has another crew challenged you? This crew is ready for any break-dance battle or classic game of hide-and-seek. Act now, supplies are limited!", 777, "https://openclipart.org/image/300px/svg_to_png/23610/StudioFibonacci-Cartoon-ninjas.png", 35.0, "Your Own Ninja Crew" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductRequests_OrderId",
                table: "ProductRequests",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ProductRequests");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
