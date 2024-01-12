using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetApplication.Migrations
{
    /// <inheritdoc />
    public partial class AssetmigrationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Model",
                value: "s13");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Model", "PurchaseDate" },
                values: new object[] { "iPhone13", new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 4,
                column: "Model",
                value: "Pro13");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 6,
                column: "PurchaseDate",
                value: new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 9,
                column: "Office",
                value: "Spain");

            migrationBuilder.InsertData(
                table: "AssetsList",
                columns: new[] { "Id", "Brand", "Currency", "LocalPrice", "Model", "Office", "Price", "PurchaseDate", "Type" },
                values: new object[,]
                {
                    { 11, "Samsung", "", 234.34m, "s13", "Sweden", 1500m, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 12, "Motorola", "", 234m, "Razr", "USA", 1200m, new DateTime(2000, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 13, "Asus ", "", 234m, "W234", "sweden", 1000m, new DateTime(2017, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer" },
                    { 14, "HP", "E", 344m, "Elitebook", "Spain", 1500m, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Model",
                value: "s 13");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Model", "PurchaseDate" },
                values: new object[] { "iPhone 13", new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 4,
                column: "Model",
                value: "Pro 13");

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 6,
                column: "PurchaseDate",
                value: new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AssetsList",
                keyColumn: "Id",
                keyValue: 9,
                column: "Office",
                value: "USA");
        }
    }
}
