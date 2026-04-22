using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsonView.API.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Inköp.webp");

            migrationBuilder.InsertData(
                table: "NewsArticles",
                columns: new[] { "Id", "Author", "Body", "Category", "ImageUrl", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 6, "CFO Anna Bergström", "Vi är glada att meddela att Sportson redovisar ett rekordresultat för det första kvartalet 2026. Omsättningen ökade med 18% jämfört med samma period förra året tack vare starka cykelförsäljningar och ökad efterfrågan på service.", "Ekonomi", "https://sportsonsbilder.blob.core.windows.net/news-images/Ekonomi6.jpeg", new DateOnly(2026, 4, 5), "Årets resultat överträffar alla förväntningar" },
                    { 7, "Anna Bergström", "Ekonomiavdelningen bjuder in alla butikschefer till en digital budgetgenomgång den 25 april. Vi går igenom prognos för Q2 och planerar inför den viktiga höstsäsongen med fokus på lönsamhet och kostnadseffektivitet.", "Ekonomi", "https://sportsonsbilder.blob.core.windows.net/news-images/Ekonomi7.png", new DateOnly(2026, 4, 8), "Budgetgenomgång inför hösten 2026" },
                    { 8, "Butiksutvecklare Lisa Svensson", "Under mars månad genomförde vi en stor kundundersökning i alla våra butiker. Resultaten visar att bemötandet och kunskapen hos vår personal är det som kunderna uppskattar allra mest hos Sportson.", "Min butik", "https://sportsonsbilder.blob.core.windows.net/news-images/MinButik8.png", new DateOnly(2026, 4, 9), "Min butik: Så ökar vi kundnöjdheten" },
                    { 9, "Butikschef Per Nilsson", "Från och med den 1 maj utökar vi öppettiderna i samtliga butiker för att möta den ökade efterfrågan under sommarmånaderna. Lördagar och söndagar kommer att ha förlängda öppettider fram till slutet av augusti.", "Min butik", "https://sportsonsbilder.blob.core.windows.net/news-images/MinButik9.png", new DateOnly(2026, 4, 10), "Nya öppettider inför sommarsäsongen" },
                    { 10, "Marknadsteamet", "Under maj och juni erbjuder vi en gratis cykelhjälm värd upp till 599 kr vid köp av valfri elcykel. Kampanjen gäller i samtliga Sportson-butiker och är ett sätt att uppmuntra säkrare cykling.", "Campaign", "https://sportsonsbilder.blob.core.windows.net/news-images/Campaign10.png", new DateOnly(2026, 4, 11), "Sommarkampanj: Gratis cykelhjälm vid köp av elcykel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Inköp.png");
        }
    }
}
