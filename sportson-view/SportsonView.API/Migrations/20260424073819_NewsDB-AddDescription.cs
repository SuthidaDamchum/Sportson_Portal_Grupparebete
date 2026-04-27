using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsonView.API.Migrations
{
    /// <inheritdoc />
    public partial class NewsDBAddDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "NewsArticles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Från måndag krävs tvåfaktorsautentisering för alla anställda. Ladda ner Microsoft Authenticator redan idag.");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Leveransen av årets elcyklar från Crescent och Monark försenas med två till tre veckor på grund av störningar i fraktkedjan.");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Vårkampanjen startar 15 april med TV, radio och sociala medier. Nytt butiksmaterial levereras under veckan.");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Samtliga verkstäder har fått ny modern utrustning, inklusive diagnostikverktyg för elcyklar och specialverktyg för Shimano.");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Just nu 20% rabatt på alla elcyklar i lager. Gäller Scott, Specialized, Trek och Crescent så långt lagret räcker.");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "Description" },
                values: new object[] { "Vi är glada att meddela att Sportson redovisar ett rekordresultat för det första kvartalet 2026. Omsättningen ökade med 18% jämfört med samma period förra året tack vare starka cykelförsäljningar och ökad efterfrågan på service.\nDen starkaste tillväxten skedde inom segmentet elcyklar, där vi såg en ökning på hela 34% jämfört med Q1 2025.\nÄven vår serviceverksamhet visade på god tillväxt, vilket bekräftar att vår satsning på välutbildad verkstadspersonal ger resultat.\nLedningen är mycket nöjd med utvecklingen och ser positivt på resten av 2026 med en stark vårskampanj på gång.\nVi vill tacka all personal för ert hårda arbete och engagemang som gjort detta rekordresultat möjligt.", "Sportson redovisar rekordresultat för Q1 2026 med 18% ökad omsättning jämfört med samma period förra året." });

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "Description" },
                values: new object[] { "Ekonomiavdelningen bjuder in alla butikschefer till en digital budgetgenomgång den 25 april.\nVi går igenom prognos för Q2 och planerar inför den viktiga höstsäsongen med fokus på lönsamhet och kostnadseffektivitet.\nUnder mötet kommer vi att gå igenom butikernas individuella resultat och jämföra med budget.\nVi kommer även att presentera nya riktlinjer för personalkostnader och lagerhållning inför hösten.\nKallelse med länk till Teams-mötet skickas ut till samtliga butikschefer senast den 22 april.\nFörbered gärna frågor och synpunkter kring er butiks utmaningar och möjligheter inför mötet.", "Butikschefer bjuds in till digital budgetgenomgång den 25 april inför höstens planering och Q2-prognos." });

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Body", "Description" },
                values: new object[] { "Under mars månad genomförde vi en stor kundundersökning i alla våra butiker.\nResultaten visar att bemötandet och kunskapen hos vår personal är det som kunderna uppskattar allra mest hos Sportson.\nHela 92% av de tillfrågade kunderna angav att de skulle rekommendera Sportson till en vän eller kollega.\nDe områden där vi har störst förbättringspotential är väntetider i kassan och tillgänglighet på populära produkter.\nVi kommer under Q2 att lansera ett nytt utbildningsprogram för all butikspersonal med fokus på kundmötet.\nMer information om programmet och hur ni anmäler er personal kommer inom kort från HR-avdelningen.", "Kundundersökningen visar att bemötande och personalkännedom är det kunderna uppskattar mest hos Sportson." });

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Body", "Description" },
                values: new object[] { "Från och med den 1 maj utökar vi öppettiderna i samtliga butiker för att möta den ökade efterfrågan under sommarmånaderna.\nLördagar och söndagar kommer att ha förlängda öppettider fram till slutet av augusti.\nVardagar öppnar vi kl 09:00 och stänger kl 19:00, medan helger gäller 10:00–17:00.\nExtra personal kommer att sättas in under helgerna för att säkerställa god service även under högtrycksperioder.\nButikschefer ansvarar för att uppdatera sina respektive butikssidor på Google och sociala medier med de nya tiderna.\nKontakta HR om ni behöver stöd med schemaläggning inför sommaren.", "Från 1 maj utökas öppettiderna i alla butiker med förlängda helgöppettider fram till slutet av augusti." });

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Body", "Description" },
                values: new object[] { "Under maj och juni erbjuder vi en gratis cykelhjälm värd upp till 599 kr vid köp av valfri elcykel.\nKampanjen gäller i samtliga Sportson-butiker och är ett sätt att uppmuntra säkrare cykling bland våra kunder.\nHjälmen väljs ut av kunden i butik och registreras som en del av köpet i kassan med en specifik kampanjkod.\nKampanjkoden och instruktioner för hur erbjudandet hanteras i kassan skickas ut till butikerna veckan innan start.\nErbjudandet gäller inte i kombination med andra rabatter eller kampanjer om inget annat anges.\nVi hoppas att kampanjen bidrar till ökad försäljning och nöjdare kunder under den viktiga sommarsäsongen.", "Gratis cykelhjälm värd upp till 599 kr vid köp av valfri elcykel under maj och juni i samtliga butiker." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "NewsArticles");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Body",
                value: "Vi är glada att meddela att Sportson redovisar ett rekordresultat för det första kvartalet 2026. Omsättningen ökade med 18% jämfört med samma period förra året tack vare starka cykelförsäljningar och ökad efterfrågan på service.");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Body",
                value: "Ekonomiavdelningen bjuder in alla butikschefer till en digital budgetgenomgång den 25 april. Vi går igenom prognos för Q2 och planerar inför den viktiga höstsäsongen med fokus på lönsamhet och kostnadseffektivitet.");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Body",
                value: "Under mars månad genomförde vi en stor kundundersökning i alla våra butiker. Resultaten visar att bemötandet och kunskapen hos vår personal är det som kunderna uppskattar allra mest hos Sportson.");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Body",
                value: "Från och med den 1 maj utökar vi öppettiderna i samtliga butiker för att möta den ökade efterfrågan under sommarmånaderna. Lördagar och söndagar kommer att ha förlängda öppettider fram till slutet av augusti.");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Body",
                value: "Under maj och juni erbjuder vi en gratis cykelhjälm värd upp till 599 kr vid köp av valfri elcykel. Kampanjen gäller i samtliga Sportson-butiker och är ett sätt att uppmuntra säkrare cykling.");
        }
    }
}
