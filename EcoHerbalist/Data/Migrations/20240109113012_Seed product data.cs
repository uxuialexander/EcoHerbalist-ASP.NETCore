using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcoHerbalist.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seedproductdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("02642904-817e-4e87-a9ab-5c8a17309ad8"), "Fresh basil plant for culinary use.", "Basil Potted Plant", 5.99m },
                    { new Guid("220ac27c-8a39-4eba-8c9f-1caeb2f9c7cd"), "Organic rosemary seeds for home cultivation.", "Rosemary Seeds", 4.99m },
                    { new Guid("258e094e-5dc4-4748-bf23-b614e27beba6"), "Dried chamomile flowers for herbal infusions.", "Chamomile Flowers", 12.99m },
                    { new Guid("5a93c0b3-6228-4714-bef3-be0b654160e3"), "Culinary sage leaves for seasoning dishes.", "Sage Leaves", 3.99m },
                    { new Guid("60ff24ee-2894-4381-8eab-5ce1cf4c1c10"), "Premium mint tea bags for a refreshing beverage.", "Mint Tea Bags", 7.99m },
                    { new Guid("65cc7f43-0366-4fc6-8f5e-6d51e713abf2"), "Pure thyme essential oil for aromatherapy.", "Thyme Essential Oil", 14.99m },
                    { new Guid("66ff75f9-3eec-40cb-b0fe-16ff172cfa6f"), "Aromatic lavender plant with soothing fragrance.", "Lavender Plant", 9.99m },
                    { new Guid("cece1d91-e0d1-4e15-8bc8-4115908f6be4"), "Echinacea plant known for immune-boosting properties.", "Echinacea Plant", 6.99m },
                    { new Guid("e54830ca-cb00-4137-97f7-779ab5abbdc7"), "Cilantro seeds for growing fresh cilantro at home.", "Cilantro Seeds", 2.99m },
                    { new Guid("e8abcdef-95f8-4ee5-bd0c-e16bbbff0e6e"), "High-quality organic turmeric powder.", "Organic Turmeric Powder", 8.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02642904-817e-4e87-a9ab-5c8a17309ad8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("220ac27c-8a39-4eba-8c9f-1caeb2f9c7cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("258e094e-5dc4-4748-bf23-b614e27beba6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a93c0b3-6228-4714-bef3-be0b654160e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60ff24ee-2894-4381-8eab-5ce1cf4c1c10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65cc7f43-0366-4fc6-8f5e-6d51e713abf2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66ff75f9-3eec-40cb-b0fe-16ff172cfa6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cece1d91-e0d1-4e15-8bc8-4115908f6be4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e54830ca-cb00-4137-97f7-779ab5abbdc7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8abcdef-95f8-4ee5-bd0c-e16bbbff0e6e"));
        }
    }
}
