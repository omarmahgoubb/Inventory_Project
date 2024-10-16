using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class updatedInventoryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18e4e168-1cf5-4869-ade1-c5ce56ef9182");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58191532-9e3b-4165-988a-6719cdc1efe9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70771752-54f0-4220-aa06-8e21dd6c4837");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96dc0baf-edaa-4d4b-880f-8a37f166b74b");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Inventories",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Inventories",
                newName: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Inventories",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Inventories",
                newName: "id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18e4e168-1cf5-4869-ade1-c5ce56ef9182", "5cbdf0f5-39a1-4b0f-889f-46e3aa868a01", "User", "USER" },
                    { "58191532-9e3b-4165-988a-6719cdc1efe9", "22e9965d-4363-475f-898f-254e37ea8301", "Admin", "ADMIN" },
                    { "70771752-54f0-4220-aa06-8e21dd6c4837", "533b5708-7cc7-4b59-8db8-578a7b4eedec", "Viewer", "viewer" },
                    { "96dc0baf-edaa-4d4b-880f-8a37f166b74b", "d824034d-6e85-4166-8562-40d3c6ee1a05", "Supplier", "supplier" }
                });
        }
    }
}
