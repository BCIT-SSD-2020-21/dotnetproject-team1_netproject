using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlez.Data.Migrations
{
    public partial class TrialV3Schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "MessageText", "UserName" },
                values: new object[] { new DateTime(2020, 12, 15, 18, 49, 34, 875, DateTimeKind.Local).AddTicks(6959), "Hello World", "JohnDoe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "MessageText", "UserName" },
                values: new object[] { new DateTime(2020, 12, 10, 16, 49, 17, 409, DateTimeKind.Local).AddTicks(7694), "Clean house", "suup" });
        }
    }
}
