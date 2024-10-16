using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class updatedInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "productQuantity",
                table: "Inventories");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a4c02ce-ddb5-4eb1-929f-bbf40b9661a2", "a290dc6a-d7ac-4f6a-b152-d69346c0200d", "User", "USER" },
                    { "47dfebb2-41ac-424e-8ca0-1c7883bc45f5", "54cf4d13-fba0-4e42-95b5-dfbe1f1be2cd", "Supplier", "supplier" },
                    { "cd2b3959-619c-44a1-8705-a462516202fd", "e422d8a7-51f3-4d17-89cb-8994e2b89dda", "Viewer", "viewer" },
                    { "e7b299d9-c55b-42cc-9260-e7720221ceed", "49c678f4-2967-4e11-adbf-87407a2195fd", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a4c02ce-ddb5-4eb1-929f-bbf40b9661a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47dfebb2-41ac-424e-8ca0-1c7883bc45f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2b3959-619c-44a1-8705-a462516202fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7b299d9-c55b-42cc-9260-e7720221ceed");

            migrationBuilder.DropColumn(
                name: "address",
                table: "Inventories");

            migrationBuilder.AddColumn<int>(
                name: "productQuantity",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
