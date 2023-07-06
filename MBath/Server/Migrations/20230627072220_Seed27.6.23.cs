using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MBath.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seed27623 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variants_Products_ProductId",
                table: "Variants");

            migrationBuilder.DropIndex(
                name: "IX_Variants_ProductId",
                table: "Variants");

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 30);

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

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Variants");

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    VariantId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.VariantId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "VariantId", "Price" },
                values: new object[,]
                {
                    { 1, 1, 145.00m },
                    { 1, 2, 160.00m },
                    { 2, 1, 145.00m },
                    { 3, 1, 160.00m },
                    { 3, 2, 175.00m },
                    { 4, 1, 170.00m },
                    { 4, 2, 185.00m },
                    { 5, 1, 155.00m },
                    { 5, 2, 165.00m },
                    { 6, 1, 155.00m },
                    { 6, 2, 165.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_VariantId",
                table: "OrderItems",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_VariantId",
                table: "ProductVariants",
                column: "VariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Variants_VariantId",
                table: "OrderItems",
                column: "VariantId",
                principalTable: "Variants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Variants_VariantId",
                table: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_VariantId",
                table: "OrderItems");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Variants",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Variants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgURL", "Name" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProductId" },
                values: new object[] { 145.00m, 1 });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProductId" },
                values: new object[] { 160.00m, 1 });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "Description", "Name", "Price", "ProductId" },
                values: new object[,]
                {
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

            migrationBuilder.CreateIndex(
                name: "IX_Variants_ProductId",
                table: "Variants",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_Products_ProductId",
                table: "Variants",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
