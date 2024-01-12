using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetApplication.Migrations
{
    /// <inheritdoc />
    public partial class migrationtabl34 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 500m);

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 900m);

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 10m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 1500m);

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 1200m);

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 1500m);
        }
    }
}
