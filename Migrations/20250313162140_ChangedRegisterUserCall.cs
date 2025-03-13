using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bangazon_New.Migrations
{
    /// <inheritdoc />
    public partial class ChangedRegisterUserCall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 3, 13, 16, 21, 40, 461, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 3, 5, 16, 21, 40, 461, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 2, 21, 16, 21, 40, 461, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 3, 13, 16, 21, 40, 461, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 3, 1, 16, 21, 40, 461, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2025, 2, 16, 16, 21, 40, 461, DateTimeKind.Utc).AddTicks(3920));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 3, 12, 20, 14, 10, 224, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 3, 4, 20, 14, 10, 224, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 2, 20, 20, 14, 10, 224, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 3, 12, 20, 14, 10, 224, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 2, 28, 20, 14, 10, 224, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2025, 2, 15, 20, 14, 10, 224, DateTimeKind.Utc).AddTicks(7200));
        }
    }
}
