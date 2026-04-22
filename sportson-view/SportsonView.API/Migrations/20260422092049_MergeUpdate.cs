using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsonView.API.Migrations
{
    /// <inheritdoc />
    public partial class MergeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "Title" },
                values: new object[] { "Vi är glada att kunna meddela att Sportson nu har investerat i en helt ny och modern verktygspark till samtliga av våra verkstäder runt om i landet. \nInvesteringen är en del av vår långsiktiga satsning på att hålla högsta möjliga servicekvalitet för våra kunder och deras cyklar. \nDe nya verktygen inkluderar avancerade diagnostikverktyg för elcyklar, kalibrerade momentnycklar och specialverktyg för Shimano Di2- och EP8-systemen. \nMed den nya utrustningen kan våra mekaniker utföra service och reparationer snabbare, säkrare och med ännu högre precision än tidigare", "Ny verktygspark installerad i samtliga butiker" });

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Minbutik8.jpg");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Minbutik9.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "Title" },
                values: new object[] { "För att bibehålla vår status som auktoriserad servicepartner för Shimano, inför vi nu skärpta krav på certifiering för all verkstadspersonal. \nDen tekniska utvecklingen går snabbt, särskilt inom elsystem och digital diagnostik, vilket kräver att vi ständigt uppdaterar vår kunskap. \nFrån och med den 1 maj kommer endast certifierade mekaniker att få utföra garantiarbeten på de nya EP8- och STEPS-systemen i våra verkstäder. \nVi har därför bokat in en serie obligatoriska utbildningsdagar som kommer att hållas digitalt samt fysiskt på tre olika platser i Sverige. \nAnmälan görs via länken i personalportalen och vi ser gärna att minst två mekaniker från varje butik deltar i de första omgångarna i vår. \nUtbildningen täcker allt från avancerad felsökning till korrekt hantering av batterier och mjukvaruuppdateringar för framtidens elcyklar. \nEfter avslutad och godkänd kurs får varje deltagare ett personligt certifikat och butiken får en dekal att sätta upp som visar vår expertis. \nVi investerar i denna utbildning för att vi vet att vår kunskap är det som gör att kunderna känner sig trygga med att lämna in sin cykel hos oss. \nVarje utbildningstillfälle tar en hel dag och vi ersätter butikerna för den tid som personalen är borta från den ordinarie produktionen. \nSe till att boka in era platser redan idag då antalet fysiska platser är begränsade för att säkerställa högsta kvalitet på undervisningen.", "Nya strikta krav på Shimano-certifiering" });

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/MinButik8.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/MinButik9.png");
        }
    }
}
