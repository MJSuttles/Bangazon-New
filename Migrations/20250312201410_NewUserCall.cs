using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bangazon_New.Migrations
{
    /// <inheritdoc />
    public partial class NewUserCall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 3, 11, 0, 15, 44, 935, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 3, 3, 0, 15, 44, 935, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 2, 19, 0, 15, 44, 935, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 3, 11, 0, 15, 44, 935, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 2, 27, 0, 15, 44, 935, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2025, 2, 14, 0, 15, 44, 935, DateTimeKind.Utc).AddTicks(580));
        }
    }
}
