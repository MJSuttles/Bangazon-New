using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bangazon_New.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllModels5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 3, 10, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 3, 2, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 2, 18, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 3, 10, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 2, 26, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2025, 2, 13, 23, 59, 16, 114, DateTimeKind.Utc).AddTicks(6850));
        }
    }
}
