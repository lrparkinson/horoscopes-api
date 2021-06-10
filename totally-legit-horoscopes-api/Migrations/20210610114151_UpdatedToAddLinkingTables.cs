using Microsoft.EntityFrameworkCore.Migrations;

namespace totally_legit_horoscopes_api.Migrations
{
    public partial class UpdatedToAddLinkingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Users_UserId",
                table: "Hobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Professions_ProfessionName",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_StarSigns_StarSignName",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_UserId",
                table: "Hobbies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Hobbies");

            migrationBuilder.AlterColumn<string>(
                name: "StarSignName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProfessionName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "HobbyUser",
                columns: table => new
                {
                    HobbiesName = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyUser", x => new { x.HobbiesName, x.UserId });
                    table.ForeignKey(
                        name: "FK_HobbyUser_Hobbies_HobbiesName",
                        column: x => x.HobbiesName,
                        principalTable: "Hobbies",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HobbyUser_UserId",
                table: "HobbyUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Professions_ProfessionName",
                table: "Users",
                column: "ProfessionName",
                principalTable: "Professions",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_StarSigns_StarSignName",
                table: "Users",
                column: "StarSignName",
                principalTable: "StarSigns",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Professions_ProfessionName",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_StarSigns_StarSignName",
                table: "Users");

            migrationBuilder.DropTable(
                name: "HobbyUser");

            migrationBuilder.AlterColumn<string>(
                name: "StarSignName",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ProfessionName",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Hobbies",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_UserId",
                table: "Hobbies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_Users_UserId",
                table: "Hobbies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Professions_ProfessionName",
                table: "Users",
                column: "ProfessionName",
                principalTable: "Professions",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_StarSigns_StarSignName",
                table: "Users",
                column: "StarSignName",
                principalTable: "StarSigns",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
