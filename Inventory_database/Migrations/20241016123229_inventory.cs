using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class inventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e5f76d5-7b39-4f1d-b097-4f055751af6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ce727a6-853a-45a7-a9b2-f72604cf3c42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d415c1e-3bb4-4ef7-ac50-0bf94fc10272");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c25a2d9-1896-412e-9529-965803e82d05");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Inventories");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e5f76d5-7b39-4f1d-b097-4f055751af6e", "e4558a5b-d795-4a16-8726-fb4a5200968b", "User", "USER" },
                    { "1ce727a6-853a-45a7-a9b2-f72604cf3c42", "956a95da-c0fa-46d6-9c6c-cfc202fefde2", "Supplier", "supplier" },
                    { "2d415c1e-3bb4-4ef7-ac50-0bf94fc10272", "4f8d62a3-9558-40f3-9164-7da83359ce02", "Admin", "ADMIN" },
                    { "6c25a2d9-1896-412e-9529-965803e82d05", "3c8045a7-d7ed-4802-937e-a62779d110bb", "Viewer", "viewer" }
                });
        }
    }
}
