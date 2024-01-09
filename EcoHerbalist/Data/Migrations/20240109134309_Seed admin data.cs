using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcoHerbalist.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seedadmindata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91640644-739c-4ab2-baf7-639ce85350fb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5dcc104a-7408-438f-a8ec-93294250fbf8", "d5518a53-6417-4d2f-94f3-adec76ce3721" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17009a0a-84d3-4b13-ae9b-ec660404c6cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a141e8c-71da-4ab9-9cd5-284ce91a6a9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d1aa645-7942-4016-8e6b-e1c03c12fef7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a2d4cc8-91ef-4d05-9f4a-14b5f69d7d72"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ad5f51e-ed20-4aa3-b2a5-a17567c56881"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b7cc75e-1f38-45dd-82c5-0bf0623c1a62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78b658e6-9a4e-4bfc-bd65-775c3146ee71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86268bf6-8f03-4254-b908-973027dff48b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96b2e73c-5dc9-4d21-8034-312c68429f93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9deb9fde-5dbf-487d-afb3-b004f6c6477d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dcc104a-7408-438f-a8ec-93294250fbf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5518a53-6417-4d2f-94f3-adec76ce3721");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27173e3e-6912-4e98-8923-7bd042ccf928", "27173e3e-6912-4e98-8923-7bd042ccf928", "user", "user" },
                    { "ab668321-dda3-41fe-a877-6736cf4fa967", "ab668321-dda3-41fe-a877-6736cf4fa967", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "62d1dae7-4048-406c-a241-2c750c5e6423", 0, "acb1aea3-6bc1-40a2-b950-3747148e7ea9", "user@user.bg", true, false, null, null, "USER@USER.BG", "AQAAAAIAAYagAAAAEKawaKJO6yxdrvZi8eFN+SwbNKUYztAKzzSXMnxr1qa+rzEGsfCDTiiipsLROvIhzw==", null, false, "386feb12-86fe-461a-8c86-33808957f8c1", false, "user@user.bg" },
                    { "6910415f-0b8c-453a-acb2-8162a0c91d15", 0, "093b68fa-ded2-4c68-a59f-391e6d75a59d", "admin@admin.bg", true, false, null, null, "ADMIN@ADMIN.BG", "AQAAAAIAAYagAAAAECr68u821sU9Rzzkv9YttHZ7m9PAwHW7j/YAk1DoZD2B0Bl1BAACsh4+L7uYpPmbFw==", null, false, "133306aa-b6f0-4811-97b2-0df8344e3b7a", false, "admin@admin.bg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("166be15b-338d-4981-87b4-1ee928a4d917"), "Dried chamomile flowers for herbal infusions.", "Chamomile Flowers", 12.99m },
                    { new Guid("226b1879-ddac-440b-868f-d773f7c28715"), "Culinary sage leaves for seasoning dishes.", "Sage Leaves", 3.99m },
                    { new Guid("444f968d-e0f0-4b3f-a86a-be3e8e40fc16"), "Cilantro seeds for growing fresh cilantro at home.", "Cilantro Seeds", 2.99m },
                    { new Guid("565367b1-fee4-48b8-ab36-fe69b4960aa8"), "High-quality organic turmeric powder.", "Organic Turmeric Powder", 8.99m },
                    { new Guid("652ea619-df94-42ca-9f6e-70e5a725924b"), "Fresh basil plant for culinary use.", "Basil Potted Plant", 5.99m },
                    { new Guid("681e7f4f-b651-4b83-a624-8fcf71de2d69"), "Pure thyme essential oil for aromatherapy.", "Thyme Essential Oil", 14.99m },
                    { new Guid("8e3a9a4a-b5f9-4337-a76c-32638d11eb53"), "Premium mint tea bags for a refreshing beverage.", "Mint Tea Bags", 7.99m },
                    { new Guid("eb9c73ea-8a60-459a-a697-4ed538f20c02"), "Echinacea plant known for immune-boosting properties.", "Echinacea Plant", 6.99m },
                    { new Guid("f5853747-ec08-4fad-8ded-28e853674999"), "Aromatic lavender plant with soothing fragrance.", "Lavender Plant", 9.99m },
                    { new Guid("fcd945cc-0563-4571-91ae-2eeb0fd45697"), "Organic rosemary seeds for home cultivation.", "Rosemary Seeds", 4.99m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "27173e3e-6912-4e98-8923-7bd042ccf928", "62d1dae7-4048-406c-a241-2c750c5e6423" },
                    { "ab668321-dda3-41fe-a877-6736cf4fa967", "6910415f-0b8c-453a-acb2-8162a0c91d15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "27173e3e-6912-4e98-8923-7bd042ccf928", "62d1dae7-4048-406c-a241-2c750c5e6423" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab668321-dda3-41fe-a877-6736cf4fa967", "6910415f-0b8c-453a-acb2-8162a0c91d15" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("166be15b-338d-4981-87b4-1ee928a4d917"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("226b1879-ddac-440b-868f-d773f7c28715"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("444f968d-e0f0-4b3f-a86a-be3e8e40fc16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("565367b1-fee4-48b8-ab36-fe69b4960aa8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("652ea619-df94-42ca-9f6e-70e5a725924b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("681e7f4f-b651-4b83-a624-8fcf71de2d69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e3a9a4a-b5f9-4337-a76c-32638d11eb53"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb9c73ea-8a60-459a-a697-4ed538f20c02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5853747-ec08-4fad-8ded-28e853674999"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fcd945cc-0563-4571-91ae-2eeb0fd45697"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27173e3e-6912-4e98-8923-7bd042ccf928");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab668321-dda3-41fe-a877-6736cf4fa967");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62d1dae7-4048-406c-a241-2c750c5e6423");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6910415f-0b8c-453a-acb2-8162a0c91d15");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5dcc104a-7408-438f-a8ec-93294250fbf8", "5dcc104a-7408-438f-a8ec-93294250fbf8", "SuperAdmin", "SUPERADMIN" },
                    { "91640644-739c-4ab2-baf7-639ce85350fb", "91640644-739c-4ab2-baf7-639ce85350fb", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d5518a53-6417-4d2f-94f3-adec76ce3721", 0, "6596cae7-b371-4f41-80e7-4174df820f8b", "admin@admin.bg", true, false, null, null, "ADMIN@ADMIN.BG", "AQAAAAIAAYagAAAAECSx4nSV0T8xxniU/Bjn9v4In8o8Le/2GkIlSxyNfxROUavpvSJOxV34VVq8YZCeNg==", null, false, "508671f0-f93c-4894-9801-6a1d4471028d", false, "admin@admin.bg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("17009a0a-84d3-4b13-ae9b-ec660404c6cd"), "Cilantro seeds for growing fresh cilantro at home.", "Cilantro Seeds", 2.99m },
                    { new Guid("5a141e8c-71da-4ab9-9cd5-284ce91a6a9e"), "Organic rosemary seeds for home cultivation.", "Rosemary Seeds", 4.99m },
                    { new Guid("5d1aa645-7942-4016-8e6b-e1c03c12fef7"), "Premium mint tea bags for a refreshing beverage.", "Mint Tea Bags", 7.99m },
                    { new Guid("6a2d4cc8-91ef-4d05-9f4a-14b5f69d7d72"), "Echinacea plant known for immune-boosting properties.", "Echinacea Plant", 6.99m },
                    { new Guid("6ad5f51e-ed20-4aa3-b2a5-a17567c56881"), "Dried chamomile flowers for herbal infusions.", "Chamomile Flowers", 12.99m },
                    { new Guid("6b7cc75e-1f38-45dd-82c5-0bf0623c1a62"), "Culinary sage leaves for seasoning dishes.", "Sage Leaves", 3.99m },
                    { new Guid("78b658e6-9a4e-4bfc-bd65-775c3146ee71"), "Fresh basil plant for culinary use.", "Basil Potted Plant", 5.99m },
                    { new Guid("86268bf6-8f03-4254-b908-973027dff48b"), "High-quality organic turmeric powder.", "Organic Turmeric Powder", 8.99m },
                    { new Guid("96b2e73c-5dc9-4d21-8034-312c68429f93"), "Aromatic lavender plant with soothing fragrance.", "Lavender Plant", 9.99m },
                    { new Guid("9deb9fde-5dbf-487d-afb3-b004f6c6477d"), "Pure thyme essential oil for aromatherapy.", "Thyme Essential Oil", 14.99m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5dcc104a-7408-438f-a8ec-93294250fbf8", "d5518a53-6417-4d2f-94f3-adec76ce3721" });
        }
    }
}
