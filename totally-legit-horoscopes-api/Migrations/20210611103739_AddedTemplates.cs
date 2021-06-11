using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace totally_legit_horoscopes_api.Migrations
{
    public partial class AddedTemplates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Horoscopes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "HoroscopeReadingTemplates",
                columns: table => new
                {
                    TemplateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Template = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoroscopeReadingTemplates", x => x.TemplateId);
                });

            migrationBuilder.InsertData(
                table: "HoroscopeReadingTemplates",
                columns: new[] { "TemplateId", "Category", "Template" },
                values: new object[,]
                {
                    { 1L, "General", "Today is a good day for {star_sign}, {ruling_planet} is approaching an auspicious house of the night sky. As a result {occupation}s such as you can look forward to a day filled with {positive_abstract_noun} but be wary of {negative_abstract_noun} which might turn this day from a win into a terrible loss." },
                    { 2L, "General", "{star_sign} beware! {ruling_planet} is in retrograde. Change isn't always a bad thing, but just in case, connect with your element {star_sign_element}.  Not a good day to start a journey. Probably best to stay home, actually. Turn to {hobby} when things get overwhelming or hug a {favourite_dinosaur} stuffie." },
                    { 3L, "General", "Oh my chaos, {star_sign}! The new moon is stirring up all the drama in your life! Time to hunker down. Close the windows, lock the doors. Don't answer the phone. Time to take a you day. Preferably in a cabin in the woods, far from civilization. Join your favourite dinosaur, {favourite_dinosaur}, in an abandoned, remote island theme park." },
                    { 4L, "General", "{star_sign}, today is not your day sadly. Creative aspirations are likely to run into hardships. The barista will most likely get your favourite coffee order wrong. A passing bird overhead may decide to poop on your best jacket. Probably best to wear your sweats today. On the bright side, a nemesis (no names, no names - {random_star_sign}) will surprise you." },
                    { 5L, "Career", "Today is the day to take chances, {star_sign}! The new moon in {ruling_planet}, means it might be time to start that project you've been hesitating on. An existing client may contact you about a new opportunity. As an {occupation}, you could not ask for a better time to push your career forward!" },
                    { 6L, "Career", "Money is being thrown at you, {star_sign}! Your hard work is paying off. The chances you took have come to fruition. It may be tempting to push even harder, for greater rewards, but take a moment to celebrate and rest. Your to do list will be there in the morning." },
                    { 7L, "Love", "Love is around the corner,  {star_sign}! You may have been feeling a bit lonely, but be assured that this will change imminently. It might be a chance encounter at your local grocery store or it could be time to take classes for {hobby} again. Get out and about. Being the {nth_child} child may have made it harder to feel worthy of love, but a gorgeous stranger is about to prove to you that you're more than worth it." },
                    { 8L, "Love", "{star_sign}, things may feel like they have stagnated. But for {ruling_planet} today, the new moon solar eclipse will breathe life back into your relationship. Plan a romantic date or swipe right on a good-looking stranger. It's time to spice things up, with the support of the new moon energy." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoroscopeReadingTemplates");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Horoscopes");
        }
    }
}
