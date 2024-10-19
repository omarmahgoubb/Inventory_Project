using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class added_supplier_In_product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "supplierId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0843476e-02db-45e5-a6f6-3da02ac99d1d", "dae07681-12b5-4abc-9d51-bf88333b5661", "User", "USER" },
                    { "dc0c87c6-356d-4860-b55d-1dffac5fab2b", "ab6ea5d3-e564-4788-82c0-f072cbc10600", "Viewer", "viewer" },
                    { "e9288f87-9f0c-4a3a-9a14-86945ad26072", "b87f72d7-f24f-43e1-bc5e-7ab6c3402030", "Admin", "ADMIN" },
                    { "f9cccb32-44df-4af0-9a87-08f203ef2a2f", "2b6fd650-a42a-4f91-875f-c38f0878c514", "Supplier", "supplier" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_supplierId",
                table: "Products",
                column: "supplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_supplierId",
                table: "Products",
                column: "supplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_supplierId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_supplierId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0843476e-02db-45e5-a6f6-3da02ac99d1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc0c87c6-356d-4860-b55d-1dffac5fab2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9288f87-9f0c-4a3a-9a14-86945ad26072");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9cccb32-44df-4af0-9a87-08f203ef2a2f");

            migrationBuilder.DropColumn(
                name: "supplierId",
                table: "Products");

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
    }
}
