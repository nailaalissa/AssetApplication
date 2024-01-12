using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetApplication.Migrations
{
    /// <inheritdoc />
    public partial class migrationassettable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 2,
                column: "Currency",
                value: "");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "Lenovo ", "", "ThinkPad" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Currency", "Model" },
                values: new object[] { "", "Pro 13" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "Asus ", "", "ROG3" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "MacBook ", "", "Pro L2" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Currency", "Model" },
                values: new object[] { "", "ROG" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "Galaxy ", "", "S21" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "Iphon", "", "iPhone 14" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "Motorola", "", "DL 13" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Currency",
                value: "SEK");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Currency",
                value: "SEK");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "Lenovo ThinkPad", "SEK", "iPhone 13" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Currency", "Model" },
                values: new object[] { "SEK", "iPhone 13" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "Asus ROG", "SEK", "iPhone 13" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "MacBook Pro", "SEK", "iPhone 13" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Currency", "Model" },
                values: new object[] { "SEK", "iPhone 13" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "Galaxy S21", "SEK", "iPhone 13" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "Iphon 14", "SEK", "iPhone 13" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Brand", "Currency", "Model" },
                values: new object[] { "", "SEK", "iPhone 13" });
        }
    }
}
