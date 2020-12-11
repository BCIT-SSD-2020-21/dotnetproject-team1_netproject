using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlez.Data.Migrations
{
    public partial class TrialV2Schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 10, 16, 49, 17, 409, DateTimeKind.Local).AddTicks(7694));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 10, 16, 27, 19, 517, DateTimeKind.Local).AddTicks(2567));
        }
    }
}
