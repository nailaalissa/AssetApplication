using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetApplication.Migrations
{
    /// <inheritdoc />
    public partial class Assetmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Currency",
                value: "USUS");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Currency", "Office" },
                values: new object[] { "EUR", "SPAIN" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "SEK", 678m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "EUR", 2340m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 6,
                column: "Currency",
                value: "US");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "EUR", 345m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "EUR", 190m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "US", 789m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "SEK", 234m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "US", 456m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 13,
                column: "Currency",
                value: "SEK");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "EUR", 588m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Currency",
                value: "");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Currency", "Office" },
                values: new object[] { "", "USA" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "", 1500m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "", 1200m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 6,
                column: "Currency",
                value: "");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "", 1200m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "", 10m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "", 1200m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "", 1500m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "", 1200m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 13,
                column: "Currency",
                value: "");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Currency", "Price" },
                values: new object[] { "E", 1500m });
        }
    }
}
