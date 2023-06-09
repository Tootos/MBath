using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MBath.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 504,
                column: "ImgURL",
                value: "\\Content\\Images\\Κουζίνα\\Αξεσουάρ Κουζίνας ανταλλακτικά.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgURL", "Name" },
                values: new object[,]
                {
                    { 500000, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Νεροχύτες ARENA.jpg", "Νεροχύτες Arena" },
                    { 500001, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Νεροχύτες Valley.jpg", "Νεροχύτες Valley.jpg" },
                    { 500002, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Νεροχύτες Valley με Πάγκο.jpg", "Νεροχύτες Valley με Πάγκο.jpg" },
                    { 500003, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Νεροχύτες Valley με δύο Γούρνες.jpg", "Νεροχύτες Valley με δύο Γούρνες.jpg" },
                    { 500004, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Νεροχύτες Valley με δύο Γούρνες και Πάγκο.jpg", "Νεροχύτες Valley με δύο Γούρνες και Πάγκο.jpg" },
                    { 500005, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Νεροχύτες Linear.jpg", "Νεροχύτες Linear.jpg" },
                    { 500006, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Νεροχύτες Criteria.jpg", "Νεροχύτες Criteria.jpg" },
                    { 500007, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Νεροχύτες Venezia με Πάγκο.jpg", "Νεροχύτες Venezia με Πάγκο" },
                    { 500008, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Νεροχύτες Venezia με δύο Γούρνες.jpg", "Νεροχύτες Venezia με δύο Γούρνες.jpg" },
                    { 500009, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Νεροχύτες Venezia με δύο Γούρνες και Πάγκο.jpg", "Νεροχύτες Venezia με δύο Γούρνες και Πάγκο.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500001);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500002);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500003);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500004);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500005);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500006);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500007);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500008);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500009);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 504,
                column: "ImgURL",
                value: "\\Content\\Images\\Κουζίνα\\Αξεσουάρ Κουζίνας.jpg");
        }
    }
}
