using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedByToCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01775f68-2048-4ed0-8573-4479ca8a1c51", "3feb9127-66c4-4c89-91ff-50b4650ab5e3", "Viewer", "viewer" },
                    { "0a8cc881-4785-4af5-8d1c-f865e0c7f7df", "7efec024-0e88-4ee7-a63d-745eca58caca", "User", "USER" },
                    { "d5e1c852-c7e6-4c69-8be7-6a34fe6be555", "1abab337-5af5-44ef-9fb2-67abc048ff7e", "Supplier", "supplier" },
                    { "e583135a-62a8-4aa2-b41a-49d683863a25", "a94163c7-4267-4d11-9271-bcdd47b75aee", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01775f68-2048-4ed0-8573-4479ca8a1c51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a8cc881-4785-4af5-8d1c-f865e0c7f7df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5e1c852-c7e6-4c69-8be7-6a34fe6be555");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e583135a-62a8-4aa2-b41a-49d683863a25");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

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
    }
}
