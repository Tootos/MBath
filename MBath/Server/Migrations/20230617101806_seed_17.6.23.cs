using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MBath.Server.Migrations
{
    /// <inheritdoc />
    public partial class seed_17623 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 500,
                column: "URL",
                value: "anoksidotoi");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 501,
                column: "URL",
                value: "synthetikoi");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 502,
                column: "URL",
                value: "mpataries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 500,
                column: "URL",
                value: "products/anoksidotoi");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 501,
                column: "URL",
                value: "products/synthetikoi");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 502,
                column: "URL",
                value: "products/mpataries");
        }
    }
}
