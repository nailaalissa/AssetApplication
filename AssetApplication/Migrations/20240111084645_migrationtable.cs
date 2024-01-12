using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetApplication.Migrations
{
    /// <inheritdoc />
    public partial class migrationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AssetsList",
                columns: new[] { "Id", "Brand", "Model", "Office", "Price", "PurchaseDate", "Type" },
                values: new object[,]
                {
                    { 1, "MacBook Pro", "iPhone 13", "USA", 1500m, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 2, "Asus ROG", "iPhone 13", "USA", 1200m, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 3, "Lenovo ThinkPad", "iPhone 13", "USA", 1000m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
