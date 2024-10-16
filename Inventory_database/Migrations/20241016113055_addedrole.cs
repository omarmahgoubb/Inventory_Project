using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class addedrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0aa771d9-8a71-45a3-845b-a028e1ff143d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "737b716f-e9bf-422e-a079-918939fb5c83");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa3caef3-9e44-4dc5-81ee-43161f6a6d61");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2421fb31-0b65-4444-bda1-5abfb9517dad", "cafcff27-f0d7-4bb7-a6a2-71aac22b117f", "Supplier", "supplier" },
                    { "48fdd631-cece-41c9-b95a-186a3508e594", "4e18f87a-1af0-42a0-9bdb-027c913eedfb", "Admin", "ADMIN" },
                    { "4fabcb37-30f3-4c6f-b128-a5e227670489", "bd0b96ea-44ce-487d-9cba-e8fd5ee2e5af", "User", "USER" },
                    { "ffa6ddc0-dc9a-4cf4-a566-754afb863682", "2b366d89-975a-4687-909c-199b22f681dd", "Viewer", "viewer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2421fb31-0b65-4444-bda1-5abfb9517dad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48fdd631-cece-41c9-b95a-186a3508e594");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fabcb37-30f3-4c6f-b128-a5e227670489");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffa6ddc0-dc9a-4cf4-a566-754afb863682");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0aa771d9-8a71-45a3-845b-a028e1ff143d", "de53a5b8-76d1-4649-986c-9842963d713c", "User", "USER" },
                    { "737b716f-e9bf-422e-a079-918939fb5c83", "7c70fdfc-5419-48ea-ab7d-867373026614", "Admin", "ADMIN" },
                    { "fa3caef3-9e44-4dc5-81ee-43161f6a6d61", "db52f7de-cf03-48c7-a514-931df1ffd127", "Viewer", "viewer" }
                });
        }
    }
}
