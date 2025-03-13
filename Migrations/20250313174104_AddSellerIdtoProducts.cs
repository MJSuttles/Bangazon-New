using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bangazon_New.Migrations
{
    /// <inheritdoc />
    public partial class AddSellerIdtoProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 3, 13, 17, 41, 4, 447, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 3, 5, 17, 41, 4, 447, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2025, 2, 21, 17, 41, 4, 447, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2025, 3, 13, 17, 41, 4, 447, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2025, 3, 1, 17, 41, 4, 447, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2025, 2, 16, 17, 41, 4, 447, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Uid",
                keyValue: "2fe66f47-afdb-4a83-9dff-2d8e60b51b7a",
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Uid",
                keyValue: "6Na5niFGCaUfZz7y9cjbFEq8twj1",
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Uid",
                keyValue: "9a53d726-a2cd-42df-9d0f-5ae1a45c1c75",
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Uid",
                keyValue: "fa80e4a1-53b7-4784-ab59-6574dea65bb0",
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Uid",
                keyValue: "l4XlJweAr3USaFL4DW3h2PfIqAC3",
                column: "ProductId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProductId",
                table: "Users",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Products_ProductId",
                table: "Users",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Products_ProductId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProductId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Users");

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
