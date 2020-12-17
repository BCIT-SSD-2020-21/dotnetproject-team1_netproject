using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlez.Data.Migrations
{
    public partial class UpdateProd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    MessageText = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CreatedOn", "MessageText", "UserId", "UserName" },
                values: new object[] { 1, new DateTime(2020, 12, 16, 18, 39, 4, 887, DateTimeKind.Local).AddTicks(9548), "Hello World", null, "JohnDoe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
