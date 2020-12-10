using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlez.Data.Migrations
{
    public partial class InitialChatv4Schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 9, 14, 53, 38, 774, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 9, 14, 53, 38, 778, DateTimeKind.Local).AddTicks(2143));
        }
    }
}
