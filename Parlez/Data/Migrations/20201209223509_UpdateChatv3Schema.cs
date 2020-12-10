using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlez.Data.Migrations
{
    public partial class UpdateChatv3Schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "UserId", "CreatedOn", "MessageId", "MessageText" },
                values: new object[] { 2, new DateTime(2020, 12, 9, 14, 35, 8, 846, DateTimeKind.Local).AddTicks(8219), 1, "How are you?" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "UserId", "CreatedOn", "MessageId", "MessageText" },
                values: new object[] { 3, new DateTime(2020, 12, 9, 14, 35, 8, 850, DateTimeKind.Local).AddTicks(3487), 2, "WasUp?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "UserId",
                keyValue: 3);
        }
    }
}
