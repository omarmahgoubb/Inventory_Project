using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedByToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

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
    }
}
