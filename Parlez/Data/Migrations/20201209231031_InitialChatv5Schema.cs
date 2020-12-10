using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlez.Data.Migrations
{
    public partial class InitialChatv5Schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 9, 15, 10, 30, 902, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 9, 15, 10, 30, 906, DateTimeKind.Local).AddTicks(576));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 9, 15, 7, 36, 277, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 9, 15, 7, 36, 281, DateTimeKind.Local).AddTicks(467));
        }
    }
}
