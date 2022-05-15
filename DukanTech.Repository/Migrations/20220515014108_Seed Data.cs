using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DukanTech.Repository.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Description", "Status", "Weight" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"), "Berry1", "Product 1", 1, "1 kg" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Berry2", "Product 2", 2, "2 kg" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b36"), "Berry3", "Product 3", 3, "3 kg" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b37"), "Berry4", "Product 4", 3, "4 kg" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b38"), "Berry5", "Product 5", 2, "5 kg" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b39"), "Berry6", "Product 6", 2, "6 Kg" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b40"), "Berry7", "Product 7", 3, "7 kg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b40"));
        }
    }
}
