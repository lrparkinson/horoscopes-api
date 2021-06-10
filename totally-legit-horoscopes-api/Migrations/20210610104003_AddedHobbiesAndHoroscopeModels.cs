using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace totally_legit_horoscopes_api.Migrations
{
    public partial class AddedHobbiesAndHoroscopeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Hobbies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Horoscopes",
                columns: table => new
                {
                    HoroscopeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reading = table.Column<string>(type: "text", nullable: false),
                    ReadingDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horoscopes", x => x.HoroscopeId);
                    table.ForeignKey(
                        name: "FK_Horoscopes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Name", "UserId" },
                values: new object[,]
                {
                    { "3D printing", null },
                    { "Flying Disc", null },
                    { "Foraging", null },
                    { "Gardening", null },
                    { "Geocaching", null },
                    { "Ghost Hunting", null },
                    { "Graffiti", null },
                    { "Handball", null },
                    { "Flying", null },
                    { "Hiking", null },
                    { "Horseback Riding", null },
                    { "Hunting", null },
                    { "Inline Skating", null },
                    { "Jogging", null },
                    { "Kayaking", null },
                    { "Kite Flying", null },
                    { "Kitesurfing", null },
                    { "Hooping", null },
                    { "Flag Football", null },
                    { "Fishing", null },
                    { "Driving", null },
                    { "Yo-yoing", null },
                    { "Air Sports", null },
                    { "Archery", null },
                    { "Astronomy", null },
                    { "Backpacking", null },
                    { "BASE Jumping", null },
                    { "Baseball", null },
                    { "Basketball", null },
                    { "Beekeeping", null },
                    { "Bird Watching", null },
                    { "Blacksmithing", null },
                    { "Board Sports", null },
                    { "Bodybuilding", null },
                    { "Brazilian Jiu-jitsu", null },
                    { "Community", null },
                    { "Cycling", null },
                    { "Dowsing", null },
                    { "LARPing", null },
                    { "Letterboxing", null },
                    { "Metal Detecting", null },
                    { "Motor Sports", null },
                    { "Sculling", null },
                    { "Rowing", null },
                    { "Shooting", null },
                    { "Shopping", null },
                    { "Skateboarding", null },
                    { "Skiing", null },
                    { "Skimboarding", null },
                    { "Skydiving", null },
                    { "Slacklining", null },
                    { "Snowboarding", null },
                    { "Stone Skipping", null },
                    { "Surfing", null },
                    { "Swimming", null },
                    { "Taekwondo", null },
                    { "Tai Chi", null },
                    { "Urban Exploration", null },
                    { "Vacation", null },
                    { "Scuba Diving", null },
                    { "Yoga", null },
                    { "Scouting", null },
                    { "Sailing", null },
                    { "Mountain Biking", null },
                    { "Mountaineering", null },
                    { "Mushroom Hunting", null },
                    { "Mycology", null },
                    { "Netball", null },
                    { "Nordic Skating", null },
                    { "Orienteering", null },
                    { "Paintball", null },
                    { "Parkour", null },
                    { "Photography", null },
                    { "Polo", null },
                    { "Rafting", null },
                    { "Rappelling", null },
                    { "Rock climbing", null },
                    { "Roller skating", null },
                    { "Rugby", null },
                    { "Running", null },
                    { "Sand art", null },
                    { "Vehicle Restoration", null },
                    { "Writing", null },
                    { "Woodworking", null },
                    { "Do It Yourself", null },
                    { "Electronics", null },
                    { "Embroidery", null },
                    { "Fashion", null },
                    { "Flower Arranging", null },
                    { "Foreign Language Learning", null },
                    { "Gaming", null },
                    { "Drawing", null },
                    { "Tabletop Games", null },
                    { "Gambling", null },
                    { "Genealogy", null },
                    { "Glassblowing", null },
                    { "Gunsmithing", null },
                    { "Homebrewing", null },
                    { "Ice skating", null },
                    { "Jewelry making", null },
                    { "Role-Playing Games", null },
                    { "Drama", null },
                    { "Digital Arts", null },
                    { "Dance", null },
                    { "Amateur Radio", null },
                    { "Acting", null },
                    { "Baton twirling", null },
                    { "Board Games", null },
                    { "Book Restoration", null },
                    { "Cabaret", null },
                    { "Calligraphy", null },
                    { "Candle Making", null },
                    { "Computer Programming", null },
                    { "Coffee Roasting", null },
                    { "Cooking", null },
                    { "Coloring", null },
                    { "Cosplaying", null },
                    { "Couponing", null },
                    { "Creative Writing", null },
                    { "Crocheting", null },
                    { "Cryptography", null },
                    { "Jigsaw puzzles", null },
                    { "Juggling", null },
                    { "Knapping", null },
                    { "Knitting", null },
                    { "Reading", null },
                    { "Scrapbooking", null },
                    { "Sculpting", null },
                    { "Sewing", null },
                    { "Singing", null },
                    { "Sketching", null },
                    { "Soapmaking", null },
                    { "Sports", null },
                    { "Stand-up Comedy", null },
                    { "Sudoku", null },
                    { "Table tennis", null },
                    { "Taxidermy", null },
                    { "Video Gaming", null },
                    { "Watching Movies", null },
                    { "Web Surfing", null },
                    { "Whittling", null },
                    { "Wood Carving", null },
                    { "Quilting", null },
                    { "Worldbuilding", null },
                    { "Puzzles", null },
                    { "Poi", null },
                    { "Kabaddi", null },
                    { "Knife Making", null },
                    { "Lacemaking", null },
                    { "Lapidary", null },
                    { "Leather Crafting", null },
                    { "Lego Building", null },
                    { "Lockpicking", null },
                    { "Machining", null },
                    { "Macrame", null },
                    { "Metalworking", null },
                    { "Magic", null },
                    { "Model Building", null },
                    { "Listening To Music", null },
                    { "Origami", null },
                    { "Painting", null },
                    { "Playing Musical Instruments", null },
                    { "Pet", null },
                    { "Pottery", null },
                    { "Water Sports", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_UserId",
                table: "Hobbies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Horoscopes_UserId",
                table: "Horoscopes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Horoscopes");
        }
    }
}
