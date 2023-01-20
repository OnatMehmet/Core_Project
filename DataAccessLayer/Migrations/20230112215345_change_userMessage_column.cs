using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class change_userMessage_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_Users_UserId1",
                table: "UserMessages");

            migrationBuilder.DropIndex(
                name: "IX_UserMessages_UserId1",
                table: "UserMessages");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserMessages");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserMessages",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_UserId",
                table: "UserMessages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_Users_UserId",
                table: "UserMessages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_Users_UserId",
                table: "UserMessages");

            migrationBuilder.DropIndex(
                name: "IX_UserMessages_UserId",
                table: "UserMessages");

            migrationBuilder.AlterColumn<bool>(
                name: "UserId",
                table: "UserMessages",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "UserMessages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_UserId1",
                table: "UserMessages",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_Users_UserId1",
                table: "UserMessages",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
