using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "supplierName",
                table: "Suppliers",
                newName: "SupplierName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Suppliers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "supplierContact",
                table: "Suppliers",
                newName: "SupplierPhone");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                table: "Suppliers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Suppliers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SupplierAddress",
                table: "Suppliers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SupplierEmail",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37dbd136-f66c-4128-8d76-908c4939a563", "1f938e78-9d44-461d-a29b-dfa6c399d6a0", "User", "USER" },
                    { "603d9b0d-99a1-4d1f-b413-a1928c5f902d", "e4c65261-2b6b-4124-a2d6-bc6b2c3e1c6f", "Admin", "ADMIN" },
                    { "c2355f87-904a-4f9c-889f-1e6bec1bb535", "1244c7aa-82e6-41a7-8253-793022b2d135", "Supplier", "supplier" },
                    { "feaf003a-c0b4-4ce5-9a3f-a984972c2260", "6c6b4bed-b41c-4344-ae2b-8f82b426ff24", "Viewer", "viewer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37dbd136-f66c-4128-8d76-908c4939a563");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "603d9b0d-99a1-4d1f-b413-a1928c5f902d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2355f87-904a-4f9c-889f-1e6bec1bb535");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "feaf003a-c0b4-4ce5-9a3f-a984972c2260");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "SupplierAddress",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "SupplierEmail",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "SupplierName",
                table: "Suppliers",
                newName: "supplierName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Suppliers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SupplierPhone",
                table: "Suppliers",
                newName: "supplierContact");

            migrationBuilder.AlterColumn<string>(
                name: "supplierName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
    }
}
