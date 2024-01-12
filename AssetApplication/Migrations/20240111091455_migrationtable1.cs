using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetApplication.Migrations
{
    /// <inheritdoc />
    public partial class migrationtable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Model" },
                values: new object[] { "Samsung", "s 13" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "PurchaseDate" },
                values: new object[] { "Iphon", new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AssetsList",
                columns: new[] { "Id", "Brand", "Model", "Office", "Price", "PurchaseDate", "Type" },
                values: new object[,]
                {
                    { 4, "MacBook Pro", "iPhone 13", "USA", 1500m, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer" },
                    { 5, "Asus ROG", "iPhone 13", "USA", 1200m, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer" },
                    { 6, "MacBook Pro", "iPhone 13", "USA", 1500m, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer" },
                    { 7, "Asus ROG", "iPhone 13", "USA", 1200m, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer" },
                    { 8, "Galaxy S21", "iPhone 13", "USA", 1200m, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 9, "Iphon 14", "iPhone 13", "USA", 1500m, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 10, "", "iPhone 13", "USA", 1200m, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Model" },
                values: new object[] { "MacBook Pro", "iPhone 13" });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "PurchaseDate" },
                values: new object[] { "Asus ROG", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
