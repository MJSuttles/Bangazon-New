using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bangazon_New.Migrations
{
    /// <inheritdoc />
    public partial class getorderfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellerId",
                value: "l4XlJweAr3USaFL4DW3h2PfIqAC3");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 3, 15, 16, 34, 41, 467, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 3, 7, 16, 34, 41, 467, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 2, 23, 16, 34, 41, 467, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 3, 15, 16, 34, 41, 467, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 3, 3, 16, 34, 41, 467, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2025, 2, 18, 16, 34, 41, 467, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "SellerId",
                value: "l4XlJweAr3USaFL4DW3h2PfIqAC3");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Indie-folk album from Taylor Swift featuring Bon Iver");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellerId",
                value: "l4XlJweAr3USaFL4DW3h2PfIqAC31");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 3, 13, 20, 53, 30, 25, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 3, 5, 20, 53, 30, 25, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 2, 21, 20, 53, 30, 25, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 3, 13, 20, 53, 30, 25, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 3, 1, 20, 53, 30, 25, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2025, 2, 16, 20, 53, 30, 25, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "SellerId",
                value: "l4XlJweAr3USaFL4DW3h2PfIqAC31");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Indie-folk album from Taylor Swift featuring Bon Iver.");
        }
    }
}
