using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bangazon_New.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 3, 8, 20, 53, 21, 215, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 2, 26, 20, 53, 21, 215, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 2, 16, 20, 53, 21, 215, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 3, 8, 20, 53, 21, 215, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 3, 3, 20, 53, 21, 215, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2025, 2, 21, 20, 53, 21, 215, DateTimeKind.Utc).AddTicks(5940));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 3, 8, 20, 48, 30, 198, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 2, 26, 20, 48, 30, 198, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 2, 16, 20, 48, 30, 198, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 3, 8, 20, 48, 30, 198, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 3, 3, 20, 48, 30, 198, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2025, 2, 21, 20, 48, 30, 198, DateTimeKind.Utc).AddTicks(3130));
        }
    }
}
