using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlez.Data.Migrations
{
    public partial class UpdateChatSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_MessageRating_MessageRatingUserId_MessageRatingMessageId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_MessageRatingUserId_MessageRatingMessageId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MessageRatingMessageId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MessageRatingUserId",
                table: "Messages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageRatingMessageId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MessageRatingUserId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_MessageRatingUserId_MessageRatingMessageId",
                table: "Messages",
                columns: new[] { "MessageRatingUserId", "MessageRatingMessageId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_MessageRating_MessageRatingUserId_MessageRatingMessageId",
                table: "Messages",
                columns: new[] { "MessageRatingUserId", "MessageRatingMessageId" },
                principalTable: "MessageRating",
                principalColumns: new[] { "UserId", "MessageId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
