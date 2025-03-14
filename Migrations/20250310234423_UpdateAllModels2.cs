using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bangazon_New.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllModels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "IsComplete", "OrderDate", "UserPaymentMethodId" },
                values: new object[,]
                {
                    { 7, "6Na5niFGCaUfZz7y9cjbFEq8twj1", false, new DateTime(2025, 3, 10, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3540), 1 },
                    { 8, "6Na5niFGCaUfZz7y9cjbFEq8twj1", true, new DateTime(2025, 3, 2, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3550), 2 },
                    { 9, "6Na5niFGCaUfZz7y9cjbFEq8twj1", true, new DateTime(2025, 2, 18, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3550), 3 },
                    { 10, "l4XlJweAr3USaFL4DW3h2PfIqAC3", false, new DateTime(2025, 3, 10, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3550), 4 },
                    { 11, "l4XlJweAr3USaFL4DW3h2PfIqAC3", true, new DateTime(2025, 2, 26, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3560), 5 },
                    { 12, "l4XlJweAr3USaFL4DW3h2PfIqAC3", true, new DateTime(2025, 2, 13, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3560), 6 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[,]
                {
                    { 9, 7, 12, 2, "l4XlJweAr3USaFL4DW3h2PfIqAC31" },
                    { 10, 7, 21, 1, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 11, 8, 33, 3, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 12, 8, 45, 2, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 13, 9, 39, 1, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 14, 9, 50, 2, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 15, 10, 24, 2, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 16, 10, 34, 1, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 17, 11, 41, 3, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 18, 11, 48, 2, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 19, 12, 28, 1, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 20, 12, 32, 2, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "IsComplete", "OrderDate", "UserPaymentMethodId" },
                values: new object[,]
                {
                    { 1, "6Na5niFGCaUfZz7y9cjbFEq8twj1", false, new DateTime(2025, 3, 10, 23, 8, 36, 682, DateTimeKind.Utc).AddTicks(1220), 1 },
                    { 2, "6Na5niFGCaUfZz7y9cjbFEq8twj1", true, new DateTime(2025, 2, 28, 23, 8, 36, 682, DateTimeKind.Utc).AddTicks(1230), 2 },
                    { 3, "6Na5niFGCaUfZz7y9cjbFEq8twj1", true, new DateTime(2025, 2, 18, 23, 8, 36, 682, DateTimeKind.Utc).AddTicks(1230), 3 },
                    { 4, "l4XlJweAr3USaFL4DW3h2PfIqAC3", false, new DateTime(2025, 3, 10, 23, 8, 36, 682, DateTimeKind.Utc).AddTicks(1230), 4 },
                    { 5, "l4XlJweAr3USaFL4DW3h2PfIqAC3", true, new DateTime(2025, 3, 5, 23, 8, 36, 682, DateTimeKind.Utc).AddTicks(1240), 5 },
                    { 6, "l4XlJweAr3USaFL4DW3h2PfIqAC3", true, new DateTime(2025, 2, 23, 23, 8, 36, 682, DateTimeKind.Utc).AddTicks(1240), 6 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[,]
                {
                    { 1, 1, 5, 2, "SellerA" },
                    { 2, 1, 8, 1, "SellerB" },
                    { 3, 2, 3, 3, "SellerC" },
                    { 4, 3, 10, 2, "SellerA" },
                    { 5, 4, 6, 4, "SellerB" },
                    { 6, 5, 7, 1, "SellerC" },
                    { 7, 5, 2, 2, "SellerA" },
                    { 8, 6, 9, 1, "SellerB" }
                });
        }
    }
}
