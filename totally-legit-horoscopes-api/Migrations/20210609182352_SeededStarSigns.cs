using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace totally_legit_horoscopes_api.Migrations
{
    public partial class SeededStarSigns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    ProfessionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.ProfessionId);
                });

            migrationBuilder.CreateTable(
                name: "StarSigns",
                columns: table => new
                {
                    StarSignId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarSigns", x => x.StarSignId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Dob = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    NthChild = table.Column<int>(type: "integer", nullable: false),
                    ProfessionId = table.Column<long>(type: "bigint", nullable: true),
                    StarSignId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "ProfessionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_StarSigns_StarSignId",
                        column: x => x.StarSignId,
                        principalTable: "StarSigns",
                        principalColumn: "StarSignId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "StarSigns",
                columns: new[] { "StarSignId", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aquarius", new DateTime(1, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(1, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pisces", new DateTime(1, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(1, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aries", new DateTime(1, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(1, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taurus", new DateTime(1, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(1, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gemini", new DateTime(1, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, new DateTime(1, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancer", new DateTime(1, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, new DateTime(1, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leo", new DateTime(1, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, new DateTime(1, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgo", new DateTime(1, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, new DateTime(1, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libra", new DateTime(1, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, new DateTime(1, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scorpius", new DateTime(1, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11L, new DateTime(1, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sagiattarius", new DateTime(1, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12L, new DateTime(1, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Capricornus", new DateTime(1, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfessionId",
                table: "Users",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StarSignId",
                table: "Users",
                column: "StarSignId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "StarSigns");
        }
    }
}
