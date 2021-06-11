using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace totally_legit_horoscopes_api.Migrations
{
    public partial class AddedPlanetsAndElementsToStarSigns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Element",
                table: "StarSigns",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RulingPlanet",
                table: "StarSigns",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Aquarius",
                columns: new[] { "Element", "RulingPlanet" },
                values: new object[] { "Air", "Uranus" });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Aries",
                columns: new[] { "Element", "RulingPlanet" },
                values: new object[] { "Fire", "Mars" });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Cancer",
                columns: new[] { "Element", "RulingPlanet", "StartDate" },
                values: new object[] { "Water", "The Moon", new DateTime(1, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Capricornus",
                columns: new[] { "Element", "RulingPlanet" },
                values: new object[] { "Earth", "Saturn" });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Gemini",
                columns: new[] { "Element", "EndDate", "RulingPlanet" },
                values: new object[] { "Air", new DateTime(1, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mercury" });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Leo",
                columns: new[] { "Element", "RulingPlanet" },
                values: new object[] { "Fire", "The Sun" });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Libra",
                columns: new[] { "Element", "EndDate", "RulingPlanet" },
                values: new object[] { "Air", new DateTime(1, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venus" });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Pisces",
                columns: new[] { "Element", "RulingPlanet" },
                values: new object[] { "Water", "Neptune" });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Sagiattarius",
                columns: new[] { "Element", "RulingPlanet" },
                values: new object[] { "Fire", "Jupiter" });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Scorpius",
                columns: new[] { "Element", "RulingPlanet", "StartDate" },
                values: new object[] { "Water", "Pluto", new DateTime(1, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Taurus",
                columns: new[] { "Element", "RulingPlanet" },
                values: new object[] { "Earth", "Venus" });

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Virgo",
                columns: new[] { "Element", "RulingPlanet" },
                values: new object[] { "Earth", "Mercury" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Element",
                table: "StarSigns");

            migrationBuilder.DropColumn(
                name: "RulingPlanet",
                table: "StarSigns");

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Cancer",
                column: "StartDate",
                value: new DateTime(1, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Gemini",
                column: "EndDate",
                value: new DateTime(1, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Libra",
                column: "EndDate",
                value: new DateTime(1, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Scorpius",
                column: "StartDate",
                value: new DateTime(1, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
