using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class updatedsupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27b78350-4713-44df-83b6-775a121b3ef8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67696f8d-33a0-43bf-91b9-e7909bb8819c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b033e78d-e1f1-4e74-a706-91e99d9b39ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f124e0ff-8d30-4944-8787-ac91e02eca73");

            migrationBuilder.AlterColumn<string>(
                name: "productName",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "productDescription",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "productQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15b6652f-4bf4-4cb1-9b57-90dd46817170", "bdc28dc8-7842-4f4d-9dc7-7b2ade3a2b00", "Viewer", "viewer" },
                    { "2d560553-9458-4a06-9a52-e9f891e7ad12", "87b9d3ab-ccfb-450d-ad0a-f752cf3b6a65", "Admin", "ADMIN" },
                    { "3c0b67e6-27f0-4bf6-a4bb-0e07dd23e357", "7e26d351-6fb4-4e9d-b4e2-08c77815d78c", "Supplier", "supplier" },
                    { "ed83eb00-dace-42b6-a48e-3872e273838b", "eb75543d-d389-448d-8871-49241c00d3a5", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15b6652f-4bf4-4cb1-9b57-90dd46817170");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d560553-9458-4a06-9a52-e9f891e7ad12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c0b67e6-27f0-4bf6-a4bb-0e07dd23e357");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed83eb00-dace-42b6-a48e-3872e273838b");

            migrationBuilder.DropColumn(
                name: "productQuantity",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "productName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "productDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27b78350-4713-44df-83b6-775a121b3ef8", "a67f94e9-e944-45a0-bdd8-e6d9ac0d7ddf", "Supplier", "supplier" },
                    { "67696f8d-33a0-43bf-91b9-e7909bb8819c", "a73c850e-b72b-48b0-b41e-898bc1c6e2ca", "User", "USER" },
                    { "b033e78d-e1f1-4e74-a706-91e99d9b39ee", "91eb626e-226e-490b-aeac-359f21c2821e", "Admin", "ADMIN" },
                    { "f124e0ff-8d30-4944-8787-ac91e02eca73", "c94e95f7-bade-412e-8159-aecf6590797c", "Viewer", "viewer" }
                });
        }
    }
}
