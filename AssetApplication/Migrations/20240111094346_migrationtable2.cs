using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetApplication.Migrations
{
    /// <inheritdoc />
    public partial class migrationtable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "AssetsList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "LocalPrice",
                table: "AssetsList",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Currency", "LocalPrice" },
                values: new object[] { "SEK", 234m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Currency", "LocalPrice" },
                values: new object[] { "SEK", 234m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Currency", "LocalPrice" },
                values: new object[] { "SEK", 234m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Currency", "LocalPrice" },
                values: new object[] { "SEK", 234m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Currency", "LocalPrice" },
                values: new object[] { "SEK", 234m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Currency", "LocalPrice" },
                values: new object[] { "SEK", 234m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Currency", "LocalPrice" },
                values: new object[] { "SEK", 234m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Currency", "LocalPrice" },
                values: new object[] { "SEK", 234m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Currency", "LocalPrice" },
                values: new object[] { "SEK", 234m });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Currency", "LocalPrice" },
                values: new object[] { "SEK", 234m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "AssetsList");

            migrationBuilder.DropColumn(
                name: "LocalPrice",
                table: "AssetsList");
        }
    }
}
