using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetApplication.Migrations
{
    /// <inheritdoc />
    public partial class migrationAssetTableData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocalPrice",
                value: 234.34m);

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 4,
                column: "LocalPrice",
                value: 344m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocalPrice",
                value: 234m);

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 4,
                column: "LocalPrice",
                value: 234m);
        }
    }
}
