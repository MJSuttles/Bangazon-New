using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bangazon_New.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllModels3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2025, 3, 10, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2025, 3, 2, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2025, 2, 18, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2025, 3, 10, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2025, 2, 26, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2025, 2, 13, 23, 46, 49, 560, DateTimeKind.Utc).AddTicks(4020));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2025, 3, 10, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2025, 3, 2, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2025, 2, 18, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2025, 3, 10, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2025, 2, 26, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2025, 2, 13, 23, 44, 23, 55, DateTimeKind.Utc).AddTicks(3560));
        }
    }
}
