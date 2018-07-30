using Microsoft.EntityFrameworkCore.Migrations;

namespace ninjashop.api.Migrations
{
    public partial class add_products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "HitPoints", "ImageUrl", "Price", "ProductName" },
                values: new object[,]
                {
                    { 7, "Hungry from all of your ninja adventures? This Pretzel Ninja will be the perfect snack to give you the energy to get back to your ninja activities!", 1, "https://openclipart.org/image/300px/svg_to_png/248493/Pretzel-Ninja-Leap.png", 4.0, "Pretzel Ninja Snack" },
                    { 8, "Looking to recruit new ninja for your crew? This poster fits perfectly on any telephone poll. We recommend using the 4-Point Shurikens to attach them for maximum recruiting impact.", 1, "https://openclipart.org/image/300px/svg_to_png/222630/request-Character-1-NINJA-2015071432.png", 7.0, "Wanted Poster" },
                    { 9, "The only equipment you need to start mastering the art of Nunchaku today!", 3, "https://openclipart.org/image/300px/svg_to_png/254907/nunchaku_by_Juhele.png", 12.0, "Nunchucks" },
                    { 10, "This highly durable quick-dry cloak is the perfect way to up your game at midnight hide-and-seek game.", 4, "https://openclipart.org/image/300px/svg_to_png/283311/cloak.png", 19.0, "Ninja Cloak" },
                    { 11, "Not just any sword. The Katana is the ultimate collectors sword for the most dedicated of ninja. Worthy to be hung over the finest fireplace mantles.", 10, "https://openclipart.org/image/300px/svg_to_png/12874/Anonymous-katana.png", 48.0, "Katana" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
