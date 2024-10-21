using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class addReportSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cd25e26-b3b8-4683-9392-5248ba042a30", "7bbf8faf-3993-441b-874a-48582efe68e3", "Supplier", "supplier" },
                    { "0d4e18ac-4852-48c5-ac22-34ef4d591e28", "d5ead1ef-cd2f-4431-973f-fa31de4c077c", "Viewer", "viewer" },
                    { "185d17ad-9118-4ee1-8aff-00c9d04f9b7e", "0efa35ad-d170-4b49-a3f4-c7e1dbe59891", "Admin", "ADMIN" },
                    { "9cc282b3-ea25-49d9-b2bf-d2734b1325ec", "a6cefed6-17a6-400a-9931-10d0bcdece93", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cd25e26-b3b8-4683-9392-5248ba042a30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d4e18ac-4852-48c5-ac22-34ef4d591e28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "185d17ad-9118-4ee1-8aff-00c9d04f9b7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cc282b3-ea25-49d9-b2bf-d2734b1325ec");

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
        }
    }
}
