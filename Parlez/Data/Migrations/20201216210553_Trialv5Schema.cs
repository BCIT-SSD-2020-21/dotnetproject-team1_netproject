using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlez.Data.Migrations
{
    public partial class Trialv5Schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 16, 13, 5, 53, 463, DateTimeKind.Local).AddTicks(378));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 16, 10, 30, 38, 184, DateTimeKind.Local).AddTicks(8045));
        }
    }
}
