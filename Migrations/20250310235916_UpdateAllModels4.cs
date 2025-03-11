using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bangazon_New.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllModels4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[] { 5, 41, 3, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[] { 5, 48, 2, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[] { 6, 28, 1, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "OrderId", "ProductId", "SellerId" },
                values: new object[] { 6, 32, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "IsComplete", "OrderDate", "UserPaymentMethodId" },
                values: new object[,]
                {
                    { 1, "6Na5niFGCaUfZz7y9cjbFEq8twj1", false, new DateTime(2025, 3, 10, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6840), 1 },
                    { 2, "6Na5niFGCaUfZz7y9cjbFEq8twj1", true, new DateTime(2025, 3, 2, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6840), 2 },
                    { 3, "6Na5niFGCaUfZz7y9cjbFEq8twj1", true, new DateTime(2025, 2, 18, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6850), 3 },
                    { 4, "l4XlJweAr3USaFL4DW3h2PfIqAC3", false, new DateTime(2025, 3, 10, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6850), 4 },
                    { 5, "l4XlJweAr3USaFL4DW3h2PfIqAC3", true, new DateTime(2025, 2, 26, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6850), 5 },
                    { 6, "l4XlJweAr3USaFL4DW3h2PfIqAC3", true, new DateTime(2025, 2, 13, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6850), 6 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[,]
                {
                    { 1, 1, 12, 2, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" },
                    { 2, 1, 21, 1, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 3, 2, 33, 3, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 4, 2, 45, 2, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 5, 3, 39, 1, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" },
                    { 6, 3, 50, 2, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" },
                    { 7, 4, 24, 2, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" },
                    { 8, 4, 34, 1, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

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

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[] { 7, 12, 2, "LoBA4EB98KfPtTZ7t8hE2xlbURw1" });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[] { 7, 21, 1, "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75" });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[] { 8, 33, 3, "fa80e4a1-53b7-4784-ab59-6574dea65bb0" });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "OrderId", "ProductId", "SellerId" },
                values: new object[] { 8, 45, "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "IsComplete", "OrderDate", "UserPaymentMethodId" },
                values: new object[,]
                {
                    { 7, "6Na5niFGCaUfZz7y9cjbFEq8twj1", false, new DateTime(2025, 3, 10, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4000), 1 },
                    { 8, "6Na5niFGCaUfZz7y9cjbFEq8twj1", true, new DateTime(2025, 3, 2, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4010), 2 },
                    { 9, "6Na5niFGCaUfZz7y9cjbFEq8twj1", true, new DateTime(2025, 2, 18, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4010), 3 },
                    { 10, "l4XlJweAr3USaFL4DW3h2PfIqAC3", false, new DateTime(2025, 3, 10, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4020), 4 },
                    { 11, "l4XlJweAr3USaFL4DW3h2PfIqAC3", true, new DateTime(2025, 2, 26, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4020), 5 },
                    { 12, "l4XlJweAr3USaFL4DW3h2PfIqAC3", true, new DateTime(2025, 2, 13, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4020), 6 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "SellerId" },
                values: new object[,]
                {
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
    }
}
