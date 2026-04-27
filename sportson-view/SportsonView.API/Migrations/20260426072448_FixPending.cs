using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsonView.API.Migrations
{
    /// <inheritdoc />
    public partial class FixPending : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NewsArticles",
                columns: new[] { "Id", "Author", "Body", "Category", "Description", "ImageUrl", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Daniel Andersson", "Som en del i vårt kontinuerliga arbete med att stärka säkerheten kring företagets digitala tillgångar, kommer vi att genomföra en stor uppgradering av inloggningssystemet. \nFrån och med måndag nästa vecka krävs tvåfaktorsautentisering (2FA) för samtliga anställda som arbetar på huvudkontoret och i våra butiker. \nDetta innebär att du utöver ditt vanliga lösenord även behöver bekräfta din identitet via Microsoft Authenticator-appen på din arbetstelefon. \nVi har sett en ökad mängd nätfiskeförsök mot liknande företag i branschen och väljer därför att ligga steget före för att skydda vår data. \nVi rekommenderar alla att ladda ner appen redan idag och följa den steg-för-steg-guide som finns publicerad på startsidan under IT-support. \nOm du saknar en arbetstelefon eller har problem med att installera applikationen, vänligen kontakta helpdesk senast fredag kl 15:00. \nDet nya systemet kommer även att göra det enklare att nå våra interna system hemifrån på ett säkert sätt utan att använda krångliga VPN-lösningar. \nVid första inloggningen på måndag kommer du att mötas av en installationsguide som tar ungefär två minuter att genomföra helt på egen hand. \nVi tackar för ert tålamod och samarbete i detta viktiga steg för att göra Sportson till en tryggare arbetsplats för oss alla digitalt sett. \nTillsammans säkerställer vi att vår kunddata och interna information förblir skyddad mot obehöriga intrång och framtida säkerhetshot.", "IT", "Från måndag krävs tvåfaktorsautentisering för alla anställda. Ladda ner Microsoft Authenticator redan idag.", "https://sportsonnews.blob.core.windows.net/sportsonnews/It1.png", new DateOnly(2026, 4, 27), "Uppdatering av intranätet och IT-säkerhet" },
                    { 2, "Sara Lindberg", "Vi har tyvärr mottagit tråkiga besked från våra logistikpartners gällande de kommande leveranserna av elcyklar från Crescent och Monark. \nPå grund av oväntade störningar i den globala fraktkedjan och tillfällig brist på specifika växelkomponenter från Shimano, dröjer leveransen. \nFörseningen beräknas just nu vara cirka två till tre veckor från det ursprungliga datumet som kommunicerades ut till butikerna i mars. \nDetta påverkar främst våra mest populära pendlarmodeller, vilket är beklagligt då vi vet att många kunder väntar ivrigt på sina cyklar. \nInköpsavdelningen arbetar dygnet runt med att hitta alternativa fraktvägar för att försöka korta ner väntetiden så mycket som det går. \nVi ber alla butikssäljare att vara proaktiva och ringa upp de kunder som har lagt handpenning för att informera om det aktuella läget. \nFör att kompensera de väntande kunderna har ledningen beslutat att vi erbjuder en gratis förstaårsservice till alla som drabbas av förseningen. \nVi skickar ut ett färdigt manus för hur detta ska kommuniceras till kunderna via e-post under eftermiddagen så att budskapet blir enhetligt. \nHåll ett öga på lagersystemet där vi kommer att uppdatera förväntade ankomstdatum så fort vi får nya bekräftelser från våra leverantörer i Asien. \nVi tackar för er förståelse och för ert hårda arbete med att hålla kundrelationerna goda trots dessa utmaningar utanför vår kontroll.", "Inköp", "Leveransen av årets elcyklar från Crescent och Monark försenas med två till tre veckor på grund av störningar i fraktkedjan.", "https://sportsonnews.blob.core.windows.net/sportsonnews/Inkop2.webp", new DateOnly(2026, 4, 27), "Leveransförseningar av årets elcyklar" },
                    { 3, "Erik Markström", "Nu är det äntligen dags att rulla ut årets absolut största och viktigaste kampanj, vår stora vårstart som kickar igång cykelsäsongen på allvar. \nMarknadsavdelningen har under flera månader arbetat med att ta fram ett koncept som verkligen sticker ut i bruset och lockar folk till butik. \nKampanjen startar officiellt den 15 april och kommer att synas stort i både TV, radio och i alla våra sociala mediekanaler under sex veckor. \nVi har tagit fram helt nytt butiksmaterial i form av vepor, gatupratare och digitala banners som börjar levereras till er under veckan. \nMålet med årets kampanj är att visa på friheten med att cykla och hur enkelt det är att byta ut bilen mot en modern elcykel i vardagen. \nVi vill uppmuntra alla butiker att planera in lokala 'provkörningsdagar' under helgerna för att låta så många som möjligt testa våra nyheter. \nGlöm inte att dokumentera era lokala event och skicka bilder till marknadsteamet, vi vill gärna visa upp det fantastiska jobbet ni gör ute i landet. \nAllt kampanjmaterial finns även tillgängligt för nedladdning i den gemensamma bildbanken om ni vill göra egna lokala annonser i tidningen. \nSäkerställ att butiksutställningen är toppad och att alla kampanjcyklar är monterade och redo för omedelbar provkörning av våra kunder. \nNu kör vi så det ryker och ser till att våren 2026 blir den mest framgångsrika perioden i Sportsons historia hittills!", "Marknad", "Vårkampanjen startar 15 april med TV, radio och sociala medier. Nytt butiksmaterial levereras under veckan.", "https://sportsonnews.blob.core.windows.net/sportsonnews/Marknad3.png", new DateOnly(2026, 4, 27), "Vårkampanjen 2026 drar äntligen igång!" },
                    { 4, "Mikael Verkstadsson", "Vi är glada att kunna meddela att Sportson nu har investerat i en helt ny och modern verktygspark till samtliga av våra verkstäder runt om i landet. \nInvesteringen är en del av vår långsiktiga satsning på att hålla högsta möjliga servicekvalitet för våra kunder och deras cyklar. \nDe nya verktygen inkluderar avancerade diagnostikverktyg för elcyklar, kalibrerade momentnycklar och specialverktyg för Shimano Di2- och EP8-systemen. \nMed den nya utrustningen kan våra mekaniker utföra service och reparationer snabbare, säkrare och med ännu högre precision än tidigare", "Verkstad", "Samtliga verkstäder har fått ny modern utrustning, inklusive diagnostikverktyg för elcyklar och specialverktyg för Shimano.", "https://sportsonnews.blob.core.windows.net/sportsonnews/Verkstad4.png", new DateOnly(2026, 4, 27), "Ny verktygspark installerad i samtliga butiker" },
                    { 5, "Marknadsteamet", "Gör dig redo för den ultimata cykelsäsongen med vårt största erbjudande någonsin på marknadens absolut bästa och mest moderna elcyklar. \nJust nu firar vi vårens ankomst med en fantastisk kampanj där vi erbjuder hela 20% rabatt på samtliga elcyklar som vi har i butikslagret. \nOavsett om du letar efter en snabb pendlarcykel för jobbet, en robust lådcykel för familjen eller en kraftfull MTB, så har vi modellen. \nDetta är ett unikt tillfälle att uppgradera ditt sätt att resa och samtidigt göra en bra affär inför de soliga dagarna som ligger framför oss. \nErbjudandet gäller alla märken såsom Scott, Specialized, Trek och Crescent, men bara så långt lagret räcker i din lokala Sportson-butik. \nKom in och prata med våra experter som hjälper dig att hitta rätt storlek och motoralternativ som passar just dina specifika behov. \nVid köp av en ny elcykel ingår som alltid vår trygga livstidsgaranti på ramen och en kostnadsfri första säkerhetskontroll efter tre månader. \nVi erbjuder även förmånlig finansiering och räntefri delbetalning för att göra det så enkelt som möjligt för dig att börja cykla direkt. \nVälkommen in till oss för en provtur som kommer att förändra din syn på vardagsmotion och pendling – känn vinden i håret utan ansträngning. \nKampanjen pågår under en begränsad tid, så vänta inte för länge med att besöka oss och säkra din favoritmodell innan den tar slut i lager!", "Campaign", "Just nu 20% rabatt på alla elcyklar i lager. Gäller Scott, Specialized, Trek och Crescent så långt lagret räcker.", "https://sportsonnews.blob.core.windows.net/sportsonnews/Kampanj5.png", new DateOnly(2026, 4, 27), "Vårkampanj: 20% rabatt på alla Elcyklar i lager!" },
                    { 6, "CFO Anna Bergström", "Vi är glada att meddela att Sportson redovisar ett rekordresultat för det första kvartalet 2026. Omsättningen ökade med 18% jämfört med samma period förra året tack vare starka cykelförsäljningar och ökad efterfrågan på service.\nDen starkaste tillväxten skedde inom segmentet elcyklar, där vi såg en ökning på hela 34% jämfört med Q1 2025.\nÄven vår serviceverksamhet visade på god tillväxt, vilket bekräftar att vår satsning på välutbildad verkstadspersonal ger resultat.\nLedningen är mycket nöjd med utvecklingen och ser positivt på resten av 2026 med en stark vårskampanj på gång.\nVi vill tacka all personal för ert hårda arbete och engagemang som gjort detta rekordresultat möjligt.", "Ekonomi", "Sportson redovisar rekordresultat för Q1 2026 med 18% ökad omsättning jämfört med samma period förra året.", "https://sportsonnews.blob.core.windows.net/sportsonnews/Ekonomi6.jpeg", new DateOnly(2026, 4, 27), "Årets resultat överträffar alla förväntningar" },
                    { 7, "Anna Bergström", "Ekonomiavdelningen bjuder in alla butikschefer till en digital budgetgenomgång den 25 april.\nVi går igenom prognos för Q2 och planerar inför den viktiga höstsäsongen med fokus på lönsamhet och kostnadseffektivitet.\nUnder mötet kommer vi att gå igenom butikernas individuella resultat och jämföra med budget.\nVi kommer även att presentera nya riktlinjer för personalkostnader och lagerhållning inför hösten.\nKallelse med länk till Teams-mötet skickas ut till samtliga butikschefer senast den 22 april.\nFörbered gärna frågor och synpunkter kring er butiks utmaningar och möjligheter inför mötet.", "Ekonomi", "Butikschefer bjuds in till digital budgetgenomgång den 25 april inför höstens planering och Q2-prognos.", "https://sportsonnews.blob.core.windows.net/sportsonnews/Ekonomi7.png", new DateOnly(2026, 4, 27), "Budgetgenomgång inför hösten 2026" },
                    { 8, "Butiksutvecklare Lisa Svensson", "Under mars månad genomförde vi en stor kundundersökning i alla våra butiker.\nResultaten visar att bemötandet och kunskapen hos vår personal är det som kunderna uppskattar allra mest hos Sportson.\nHela 92% av de tillfrågade kunderna angav att de skulle rekommendera Sportson till en vän eller kollega.\nDe områden där vi har störst förbättringspotential är väntetider i kassan och tillgänglighet på populära produkter.\nVi kommer under Q2 att lansera ett nytt utbildningsprogram för all butikspersonal med fokus på kundmötet.\nMer information om programmet och hur ni anmäler er personal kommer inom kort från HR-avdelningen.", "Min butik", "Kundundersökningen visar att bemötande och personalkännedom är det kunderna uppskattar mest hos Sportson.", "https://sportsonnews.blob.core.windows.net/sportsonnews/Minbutik8.jpg", new DateOnly(2026, 4, 27), "Min butik: Så ökar vi kundnöjdheten" },
                    { 9, "Butikschef Per Nilsson", "Från och med den 1 maj utökar vi öppettiderna i samtliga butiker för att möta den ökade efterfrågan under sommarmånaderna.\nLördagar och söndagar kommer att ha förlängda öppettider fram till slutet av augusti.\nVardagar öppnar vi kl 09:00 och stänger kl 19:00, medan helger gäller 10:00–17:00.\nExtra personal kommer att sättas in under helgerna för att säkerställa god service även under högtrycksperioder.\nButikschefer ansvarar för att uppdatera sina respektive butikssidor på Google och sociala medier med de nya tiderna.\nKontakta HR om ni behöver stöd med schemaläggning inför sommaren.", "Min butik", "Från 1 maj utökas öppettiderna i alla butiker med förlängda helgöppettider fram till slutet av augusti.", "https://sportsonnews.blob.core.windows.net/sportsonnews/Minbutik9.jpg", new DateOnly(2026, 4, 27), "Nya öppettider inför sommarsäsongen" },
                    { 10, "Marknadsteamet", "Under maj och juni erbjuder vi en gratis cykelhjälm värd upp till 599 kr vid köp av valfri elcykel.\nKampanjen gäller i samtliga Sportson-butiker och är ett sätt att uppmuntra säkrare cykling bland våra kunder.\nHjälmen väljs ut av kunden i butik och registreras som en del av köpet i kassan med en specifik kampanjkod.\nKampanjkoden och instruktioner för hur erbjudandet hanteras i kassan skickas ut till butikerna veckan innan start.\nErbjudandet gäller inte i kombination med andra rabatter eller kampanjer om inget annat anges.\nVi hoppas att kampanjen bidrar till ökad försäljning och nöjdare kunder under den viktiga sommarsäsongen.", "Campaign", "Gratis cykelhjälm värd upp till 599 kr vid köp av valfri elcykel under maj och juni i samtliga butiker.", "https://sportsonnews.blob.core.windows.net/sportsonnews/Campaign10.png", new DateOnly(2026, 4, 27), "Sommarkampanj: Gratis cykelhjälm vid köp av elcykel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 5);

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
        }
    }
}
