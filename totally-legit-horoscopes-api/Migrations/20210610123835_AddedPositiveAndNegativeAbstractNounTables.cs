using Microsoft.EntityFrameworkCore.Migrations;

namespace totally_legit_horoscopes_api.Migrations
{
    public partial class AddedPositiveAndNegativeAbstractNounTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NegativeAbstractNouns",
                columns: table => new
                {
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NegativeAbstractNouns", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "PositiveAbstractNouns",
                columns: table => new
                {
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositiveAbstractNouns", x => x.Value);
                });

            migrationBuilder.InsertData(
                table: "NegativeAbstractNouns",
                column: "Value",
                values: new object[]
                {
                    "Anger",
                    "Hurt",
                    "Infatuation",
                    "Insanity",
                    "Jealousy",
                    "Loss",
                    "Misery",
                    "Pain",
                    "Poverty",
                    "Tiredness",
                    "Sadness",
                    "Helplessness",
                    "Sensitivity",
                    "Sorrow",
                    "Stupidity",
                    "Speculation",
                    "Submission",
                    "Tolerance",
                    "Uncertainty",
                    "Unreality",
                    "Weakness",
                    "Weariness",
                    "Worry",
                    "Silliness",
                    "Hatred",
                    "Wariness",
                    "Grief",
                    "Hate",
                    "Anxiety",
                    "Brutality",
                    "Coldness",
                    "Crime",
                    "Curiosity",
                    "Death",
                    "Deceit",
                    "Defeat",
                    "Despair",
                    "Disappointment",
                    "Chaos",
                    "Disturbance",
                    "Disbelief",
                    "Fragility",
                    "Favoritism",
                    "Faithlessness",
                    "Fear",
                    "Evil",
                    "Envy",
                    "Ego",
                    "Disquiet",
                    "Failure",
                    "Frailty"
                });

            migrationBuilder.InsertData(
                table: "PositiveAbstractNouns",
                column: "Value",
                values: new object[]
                {
                    "Pleasure",
                    "Perseverance",
                    "Maturity",
                    "Peace",
                    "Patience",
                    "Opportunity",
                    "Opportunism",
                    "Motivation",
                    "Mercy",
                    "Liberty",
                    "Luck",
                    "Loyalty",
                    "Love",
                    "Laughter",
                    "Kindness",
                    "Joy",
                    "Intelligence",
                    "Power",
                    "Integrity",
                    "Luxury",
                    "Pride",
                    "Sophistication",
                    "Redemption",
                    "Infatuation",
                    "Wealth",
                    "Warmth",
                    "Victory",
                    "Trust",
                    "Talent",
                    "Sympathy",
                    "Success",
                    "Strength",
                    "Speed",
                    "Silliness",
                    "Sensitivity",
                    "Self-control",
                    "Satisfaction",
                    "Sanity",
                    "Romance",
                    "Relief",
                    "Relaxation",
                    "Refreshment",
                    "Principle",
                    "Humor",
                    "Courage",
                    "Hope",
                    "Contentment",
                    "Consideration",
                    "Confidence",
                    "Compassion",
                    "Comfort",
                    "Clarity",
                    "Charity",
                    "Calmness",
                    "Brilliance",
                    "Bravery",
                    "Belief",
                    "Beauty",
                    "Awe",
                    "Artistry",
                    "Apprehension",
                    "Amazement",
                    "Adventure",
                    "Adoration",
                    "Ability",
                    "Wisdom",
                    "Curiosity",
                    "Dedication",
                    "Delight",
                    "Honor",
                    "Honesty",
                    "Helpfulness",
                    "Happiness",
                    "Graciousness",
                    "Grace",
                    "Goodness",
                    "Generosity",
                    "Friendship",
                    "Humility",
                    "Freedom",
                    "Favoritism",
                    "Fascination",
                    "Faithfulness",
                    "Faith",
                    "Excitement",
                    "Enthusiasm",
                    "Energy",
                    "Elegance",
                    "Determination",
                    "Forgiveness",
                    "Wit"
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NegativeAbstractNouns");

            migrationBuilder.DropTable(
                name: "PositiveAbstractNouns");
        }
    }
}
