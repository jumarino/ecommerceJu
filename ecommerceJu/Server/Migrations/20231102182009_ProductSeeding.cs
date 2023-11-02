using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecommerceJu.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Nespresso capsules were sold exclusively by Nespresso while the machines were under patent, and are significantly more expensive than an equivalent quantity of loose ground coffee.", "", 19.99m, "Nespresso" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Nescafé Dolce Gusto coffee capsules come in a variety of pack sizes which contain 12, 16 or 30 capsules. 12 pod boxes can make between 6 – 12 cups and 30 pod boxes are sufficient enough for between 15 – 30 cups, depending on the type of beverage.", "https://upload.wikimedia.org/wikipedia/commons/a/ab/Logo_Nescaf%C3%A9_dolce_gusto.png", 29.99m, "Dolce Gusto" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Starbucks Verismo became publicly available, consisting of a line of coffee makers that brew espresso and regular chocolate from coffee capsules, a type of pre-apportioned single-use container of ground coffee and flavourings utilizing the K-Fee pod system.", "https://upload.wikimedia.org/wikipedia/pt/0/0f/Starbucks_Corporation_Logo_2011.svg.png", 39.99m, "Starbucks" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
