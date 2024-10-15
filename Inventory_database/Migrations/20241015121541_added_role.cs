using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class added_role : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "278d4f30-c965-4866-9f35-1046e54ec1a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0662404-2520-4601-b52a-7d25436143f7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c803dac-ab8a-43a5-a74e-e15b803efdce", "a8af44ac-ea93-4631-b717-77e8fc18710d", "Admin", "ADMIN" },
                    { "f3e27649-4e61-4cb8-85da-a5ca1334a436", "906554f1-d783-4201-8534-f3fab8be7db5", "User", "USER" },
                    { "fdfebf66-14aa-484e-af40-ba7201460558", "e1cbaeea-fa33-44a2-b81e-3f0bdb031c35", "Viewer", "viewer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c803dac-ab8a-43a5-a74e-e15b803efdce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3e27649-4e61-4cb8-85da-a5ca1334a436");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdfebf66-14aa-484e-af40-ba7201460558");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "278d4f30-c965-4866-9f35-1046e54ec1a7", "d47463fd-6c26-470e-a823-8aebac534bbf", "Admin", "ADMIN" },
                    { "a0662404-2520-4601-b52a-7d25436143f7", "4646ed67-6319-44b3-b67c-2d629902e9f7", "User", "USER" }
                });
        }
    }
}
