using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MBath.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgURL", "Name", "ParentId", "URL" },
                values: new object[,]
                {
                    { 1, "\\Content\\Images\\Ύδρευση.jpg", "'Υδρευση", 0, "ydreusi" },
                    { 2, "http://www.m-bath.gr/wp-content/uploads/2014/04/unisolsifoni.jpg", "Αποχέτευση", 0, "apoxeteusi" },
                    { 3, "http://www.m-bath.gr/wp-content/uploads/2014/04/unisolsifoni.jpg", "Θερμοσίφωνα", 0, "thermosifona" },
                    { 4, "http://www.m-bath.gr/wp-content/uploads/2014/04/unisolsifoni.jpg", "Μπάνιο", 0, "mpanio" },
                    { 5, "\\Content\\Images\\Κουζίνα.jpg", "Κουζίνα", 0, "kouzina" },
                    { 100, "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg", "Εξαρτήματα", 1, "eksartimata" },
                    { 101, "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg", "Σωλήνες", 1, "solines" },
                    { 102, "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg", "Διακόπτες", 1, "diakoptes" },
                    { 200, "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg", "Σωλήνες PVC", 2, "solinespvc" },
                    { 201, "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg", "Σιφώνια αποχέτευσης", 2, "sifoniaapoxeteusis" },
                    { 300, "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg", "Ηλεκτρομπόιλερ", 3, "hlectroboiler" },
                    { 301, "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg", "Ηλεκτρικά Θερμοσίφωνα", 3, "elektrikathermosifona" },
                    { 500, "\\Content\\Images\\Κουζίνα\\Ανοξείδωτοι Νεροχύτες.jpg", "Ανοξείδωτοι Νεροχύτες", 5, "anoksidotoi" },
                    { 501, "\\Content\\Images\\Κουζίνα\\Νεροχύτες Συνθετικοί.jpg", "Νεροχύτες Συνθετικοί", 5, "synthetikoi" },
                    { 502, "\\Content\\Images\\Κουζίνα\\Μπαταρίες.jpg", "Μπαταρίες", 5, "mpataries" },
                    { 503, "\\Content\\Images\\Κουζίνα\\Απορροφητήρες.jpg", "Απορροφητήρες", 5, "aporrofitires" },
                    { 504, "\\Content\\Images\\Κουζίνα\\Αξεσουάρ Κουζίνας.jpg", "Αξεσουάρ Κουζίνας", 5, "aksesouar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
