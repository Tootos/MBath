using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MBath.Server.Migrations
{
    /// <inheritdoc />
    public partial class seed1623 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgURL",
                value: "\\Content\\Images\\Αποχέτευση.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgURL",
                value: "\\Content\\Images\\Θερμοσίφωνα.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgURL",
                value: "\\Content\\Images\\Μπάνιο.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgURL", "Name" },
                values: new object[,]
                {
                    { 1, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8310.jpg", "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8310" },
                    { 2, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 100x50 VENEZIA 8312.jpg", "Ανοξείδοτος νεροχύτης 100x50 VENEZIA 8312" },
                    { 3, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 116x50 VENEZIA 8316.jpg", "Ανοξείδοτος νεροχύτης 116x50 VENEZIA 8316" },
                    { 4, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8320.jpg", "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8320" },
                    { 5, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8330.jpg", "Ανοξείδοτος νεροχύτης 86x50 VENEZIA 8330" },
                    { 6, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 79x50 VENEZIA 8380.jpg", "Ανοξείδοτος νεροχύτης 79x50 VENEZIA 8380" },
                    { 7, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 78,5x44,5 SLENDER 24200.jpg", "Ανοξείδοτος νεροχύτης 78,5x44,5 SLENDER 24200" },
                    { 8, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 60x50 ARENA 22060.jpg", "Ανοξείδοτος νεροχύτης 60x50 ARENA 22060" },
                    { 9, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 80x50 ARENA 22080.jpg", "Ανοξείδοτος νεροχύτης 80x50 ARENA 22080" },
                    { 10, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 44,5x44,5 VALLEY 24050.jpg", "Ανοξείδοτος νεροχύτης 44,5x44,5 VALLEY 24050" },
                    { 11, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 38x38 VALLEY 25038.jpg", "Ανοξείδοτος νεροχύτης 38x38 VALLEY 25038" },
                    { 12, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 50x50 VALLEY 25050.jpg", "Ανοξείδοτος νεροχύτης 50x50 VALLEY 25050" },
                    { 13, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 60x50 VALLEY 25060.jpg", "Ανοξείδοτος νεροχύτης 60x50 VALLEY 25060" },
                    { 14, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 78x50 VALLEY 25100.jpg", "Ανοξείδοτος νεροχύτης 78x50 VALLEY 25100" },
                    { 15, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 78x50 VALLEY 25105.jpg", "Ανοξείδοτος νεροχύτης 78x50 VALLEY 25105" },
                    { 16, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 80x50 VALLEY 25200.jpg", "Ανοξείδοτος νεροχύτης 80x50 VALLEY 25200" },
                    { 17, 500, "", "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες\\Ανοξείδοτος νεροχύτης 126x50 VALLEY 25210.jpg", "Ανοξείδοτος νεροχύτης 126x50 VALLEY 25210" }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "Description", "Name", "Price", "ProductId" },
                values: new object[,]
                {
                    { 1, "", "Λεία επιφάνεια", 145.00m, 1 },
                    { 2, "", "Σαγρέ επιφάνεια", 160.00m, 1 },
                    { 3, "", "Λεία επιφάνεια", 285.00m, 2 },
                    { 4, "", "Λεία επιφάνεια", 160.00m, 3 },
                    { 5, "", "Σαγρέ επιφάνεια", 175.00m, 3 },
                    { 6, "", "Λεία επιφάνεια", 170.00m, 4 },
                    { 7, "", "Λεία επιφάνεια", 185.00m, 4 },
                    { 8, "", "Λεία επιφάνεια", 155.00m, 5 },
                    { 9, "", "Σαγρέ επιφάνεια", 165.00m, 5 },
                    { 10, "", "Λεία επιφάνεια", 170.00m, 4 },
                    { 11, "", "Λεία επιφάνεια", 185.00m, 4 },
                    { 12, "", "Λεία επιφάνεια", 155.00m, 5 },
                    { 13, "", "Σαγρέ επιφάνεια", 165.00m, 5 },
                    { 14, "", "Λεία επιφάνεια", 155.00m, 6 },
                    { 15, "", "Σαγρέ επιφάνεια", 165.00m, 6 },
                    { 16, "", "Λεία επιφάνεια", 75.00m, 7 },
                    { 17, "", "Λεία επιφάνεια", 100.00m, 8 },
                    { 18, "", "Σαγρέ επιφάνεια", 109.00m, 8 },
                    { 19, "", "Λεία επιφάνεια", 125.00m, 9 },
                    { 20, "", "Σαγρέ επιφάνεια", 145.00m, 9 },
                    { 21, "", "Λεία επιφάνεια", 50.00m, 10 },
                    { 22, "", "Λεία επιφάνεια", 50.00m, 11 },
                    { 23, "", "Λεία επιφάνεια", 60.00m, 12 },
                    { 24, "", "Λεία επιφάνεια", 72.00m, 13 },
                    { 25, "", "Λεία επιφάνεια", 70.00m, 14 },
                    { 26, "", "Λεία επιφάνεια", 80.00m, 15 },
                    { 27, "", "Σαγρέ επιφάνεια", 91.00m, 15 },
                    { 28, "", "Λεία επιφάνεια", 90.00m, 16 },
                    { 29, "", "Σαγρε επιφάνεια", 110.00m, 16 },
                    { 30, "", "Λεία επιφάνεια", 113.00m, 17 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variants");

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgURL",
                value: "http://www.m-bath.gr/wp-content/uploads/2014/04/unisolsifoni.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgURL",
                value: "http://www.m-bath.gr/wp-content/uploads/2014/04/unisolsifoni.jpg");

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
    }
}
