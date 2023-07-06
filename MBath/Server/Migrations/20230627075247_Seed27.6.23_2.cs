using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MBath.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seed27623_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 200,
                column: "ImgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 201,
                column: "ImgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 300,
                column: "ImgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 301,
                column: "ImgURL",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 200,
                column: "ImgURL",
                value: "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 201,
                column: "ImgURL",
                value: "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 300,
                column: "ImgURL",
                value: "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 301,
                column: "ImgURL",
                value: "http://www.m-bath.gr/wp-content/uploads/2014/06/types-of-plumbing-pipes.jpg");
        }
    }
}
