using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_database.Migrations
{
    /// <inheritdoc />
    public partial class updatedInventoryWithProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "inventoryId",
                table: "Products",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_inventoryId",
                table: "Products",
                column: "inventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Inventories_inventoryId",
                table: "Products",
                column: "inventoryId",
                principalTable: "Inventories",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Inventories_inventoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_inventoryId",
                table: "Products");

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

            migrationBuilder.DropColumn(
                name: "inventoryId",
                table: "Products");

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
    }
}
