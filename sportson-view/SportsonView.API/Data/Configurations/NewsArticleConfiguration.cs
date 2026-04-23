using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsonView.API.Data.Entities;

namespace SportsonView.API.Data.Configurations
{
    public class NewsArticleConfiguration : IEntityTypeConfiguration<NewsArticle>

    {
        public void Configure(EntityTypeBuilder<NewsArticle> builder)
        {
            builder.HasData(
                new NewsArticle
                {
                    Id =1,
                    Title = "Uppdatering av intranätet och IT-säkerhet",
                    Body = "Som en del i vårt kontinuerliga arbete med att stärka säkerheten kring företagets digitala tillgångar, kommer vi att genomföra en stor uppgradering av inloggningssystemet. \n" +
                        "Från och med måndag nästa vecka krävs tvåfaktorsautentisering (2FA) för samtliga anställda som arbetar på huvudkontoret och i våra butiker. \n" +
                        "Detta innebär att du utöver ditt vanliga lösenord även behöver bekräfta din identitet via Microsoft Authenticator-appen på din arbetstelefon. \n" +
                        "Vi har sett en ökad mängd nätfiskeförsök mot liknande företag i branschen och väljer därför att ligga steget före för att skydda vår data. \n" +
                        "Vi rekommenderar alla att ladda ner appen redan idag och följa den steg-för-steg-guide som finns publicerad på startsidan under IT-support. \n" +
                        "Om du saknar en arbetstelefon eller har problem med att installera applikationen, vänligen kontakta helpdesk senast fredag kl 15:00. \n" +
                        "Det nya systemet kommer även att göra det enklare att nå våra interna system hemifrån på ett säkert sätt utan att använda krångliga VPN-lösningar. \n" +
                        "Vid första inloggningen på måndag kommer du att mötas av en installationsguide som tar ungefär två minuter att genomföra helt på egen hand. \n" +
                        "Vi tackar för ert tålamod och samarbete i detta viktiga steg för att göra Sportson till en tryggare arbetsplats för oss alla digitalt sett. \n" +
                        "Tillsammans säkerställer vi att vår kunddata och interna information förblir skyddad mot obehöriga intrång och framtida säkerhetshot.",
                    Author = "Daniel Andersson",
                    PublishedDate = new DateOnly(2026, 04, 01),
                    Category = "IT",
                    ImageUrl = "https://sportsonnews.blob.core.windows.net/sportsonnews/It1.png"
                },
                new NewsArticle
                {
                    Id = 2,
                    Title = "Leveransförseningar av årets elcyklar",
                    Body = "Vi har tyvärr mottagit tråkiga besked från våra logistikpartners gällande de kommande leveranserna av elcyklar från Crescent och Monark. \n" +
                        "På grund av oväntade störningar i den globala fraktkedjan och tillfällig brist på specifika växelkomponenter från Shimano, dröjer leveransen. \n" +
                        "Förseningen beräknas just nu vara cirka två till tre veckor från det ursprungliga datumet som kommunicerades ut till butikerna i mars. \n" +
                        "Detta påverkar främst våra mest populära pendlarmodeller, vilket är beklagligt då vi vet att många kunder väntar ivrigt på sina cyklar. \n" +
                        "Inköpsavdelningen arbetar dygnet runt med att hitta alternativa fraktvägar för att försöka korta ner väntetiden så mycket som det går. \n" +
                        "Vi ber alla butikssäljare att vara proaktiva och ringa upp de kunder som har lagt handpenning för att informera om det aktuella läget. \n" +
                        "För att kompensera de väntande kunderna har ledningen beslutat att vi erbjuder en gratis förstaårsservice till alla som drabbas av förseningen. \n" +
                        "Vi skickar ut ett färdigt manus för hur detta ska kommuniceras till kunderna via e-post under eftermiddagen så att budskapet blir enhetligt. \n" +
                        "Håll ett öga på lagersystemet där vi kommer att uppdatera förväntade ankomstdatum så fort vi får nya bekräftelser från våra leverantörer i Asien. \n" +
                        "Vi tackar för er förståelse och för ert hårda arbete med att hålla kundrelationerna goda trots dessa utmaningar utanför vår kontroll.",
                    Author = "Sara Lindberg",
                    PublishedDate = new DateOnly(2026, 04, 02),
                    Category = "Inköp",
                    ImageUrl = "https://sportsonnews.blob.core.windows.net/sportsonnews/Inkop2.webp"
                },
                new NewsArticle
                {
                    Id = 3,
                    Title = "Vårkampanjen 2026 drar äntligen igång!",
                    Body = "Nu är det äntligen dags att rulla ut årets absolut största och viktigaste kampanj, vår stora vårstart som kickar igång cykelsäsongen på allvar. \n" +
                        "Marknadsavdelningen har under flera månader arbetat med att ta fram ett koncept som verkligen sticker ut i bruset och lockar folk till butik. \n" +
                        "Kampanjen startar officiellt den 15 april och kommer att synas stort i både TV, radio och i alla våra sociala mediekanaler under sex veckor. \n" +
                        "Vi har tagit fram helt nytt butiksmaterial i form av vepor, gatupratare och digitala banners som börjar levereras till er under veckan. \n" +
                        "Målet med årets kampanj är att visa på friheten med att cykla och hur enkelt det är att byta ut bilen mot en modern elcykel i vardagen. \n" +
                        "Vi vill uppmuntra alla butiker att planera in lokala 'provkörningsdagar' under helgerna för att låta så många som möjligt testa våra nyheter. \n" +
                        "Glöm inte att dokumentera era lokala event och skicka bilder till marknadsteamet, vi vill gärna visa upp det fantastiska jobbet ni gör ute i landet. \n" +
                        "Allt kampanjmaterial finns även tillgängligt för nedladdning i den gemensamma bildbanken om ni vill göra egna lokala annonser i tidningen. \n" +
                        "Säkerställ att butiksutställningen är toppad och att alla kampanjcyklar är monterade och redo för omedelbar provkörning av våra kunder. \n" +
                        "Nu kör vi så det ryker och ser till att våren 2026 blir den mest framgångsrika perioden i Sportsons historia hittills!",
                    Author = "Erik Markström",
                    PublishedDate = new DateOnly(2026, 04, 03),
                    Category = "Marknad",
                    ImageUrl = "https://sportsonnews.blob.core.windows.net/sportsonnews/Marknad3.png"
                },
        new NewsArticle
        {
            Id = 4,
            Title = "Ny verktygspark installerad i samtliga butiker",
            Body = "Vi är glada att kunna meddela att Sportson nu har investerat i en helt ny och modern verktygspark till samtliga av våra verkstäder runt om i landet. \n" +
           "Investeringen är en del av vår långsiktiga satsning på att hålla högsta möjliga servicekvalitet för våra kunder och deras cyklar. \n" +
           "De nya verktygen inkluderar avancerade diagnostikverktyg för elcyklar, kalibrerade momentnycklar och specialverktyg för Shimano Di2- och EP8-systemen. \n" +
           "Med den nya utrustningen kan våra mekaniker utföra service och reparationer snabbare, säkrare och med ännu högre precision än tidigare",
            Author = "Mikael Verkstadsson",
            PublishedDate = new DateOnly(2026, 04, 04),
            Category = "Verkstad",
            ImageUrl = "https://sportsonnews.blob.core.windows.net/sportsonnews/Verkstad4.png"
        },
        new NewsArticle
        {
            Id = 5,
            Title = "Vårkampanj: 20% rabatt på alla Elcyklar i lager!",
            Body = "Gör dig redo för den ultimata cykelsäsongen med vårt största erbjudande någonsin på marknadens absolut bästa och mest moderna elcyklar. \n" +
                    "Just nu firar vi vårens ankomst med en fantastisk kampanj där vi erbjuder hela 20% rabatt på samtliga elcyklar som vi har i butikslagret. \n" +
                    "Oavsett om du letar efter en snabb pendlarcykel för jobbet, en robust lådcykel för familjen eller en kraftfull MTB, så har vi modellen. \n" +
                    "Detta är ett unikt tillfälle att uppgradera ditt sätt att resa och samtidigt göra en bra affär inför de soliga dagarna som ligger framför oss. \n" +
                    "Erbjudandet gäller alla märken såsom Scott, Specialized, Trek och Crescent, men bara så långt lagret räcker i din lokala Sportson-butik. \n" +
                    "Kom in och prata med våra experter som hjälper dig att hitta rätt storlek och motoralternativ som passar just dina specifika behov. \n" +
                    "Vid köp av en ny elcykel ingår som alltid vår trygga livstidsgaranti på ramen och en kostnadsfri första säkerhetskontroll efter tre månader. \n" +
                    "Vi erbjuder även förmånlig finansiering och räntefri delbetalning för att göra det så enkelt som möjligt för dig att börja cykla direkt. \n" +
                    "Välkommen in till oss för en provtur som kommer att förändra din syn på vardagsmotion och pendling – känn vinden i håret utan ansträngning. \n" +
                    "Kampanjen pågår under en begränsad tid, så vänta inte för länge med att besöka oss och säkra din favoritmodell innan den tar slut i lager!",
            Author = "Marknadsteamet",
            PublishedDate = new DateOnly(2026, 04, 12),
            Category = "Campaign",
            ImageUrl = "https://sportsonnews.blob.core.windows.net/sportsonnews/Kampanj5.png"
        },
            new NewsArticle
            {
                Id = 6,
                Title = "Årets resultat överträffar alla förväntningar",
                Body = "Vi är glada att meddela att Sportson redovisar ett rekordresultat för det första kvartalet 2026. Omsättningen ökade med 18% jämfört med samma period förra året tack vare starka cykelförsäljningar och ökad efterfrågan på service.",
                Author = "CFO Anna Bergström",
                PublishedDate = new DateOnly(2026, 04, 05),
                Category = "Ekonomi",
                ImageUrl = "https://sportsonnews.blob.core.windows.net/sportsonnews/Ekonomi6.jpeg"
            },
            new NewsArticle
            {
                Id = 7,
                Title = "Budgetgenomgång inför hösten 2026",
                Body = "Ekonomiavdelningen bjuder in alla butikschefer till en digital budgetgenomgång den 25 april. Vi går igenom prognos för Q2 och planerar inför den viktiga höstsäsongen med fokus på lönsamhet och kostnadseffektivitet.",
                Author = "Anna Bergström",
                PublishedDate = new DateOnly(2026, 04, 08),
                Category = "Ekonomi",
                ImageUrl = "https://sportsonnews.blob.core.windows.net/sportsonnews/Ekonomi7.png"
            },
            new NewsArticle
            {
                Id = 8,
                Title = "Min butik: Så ökar vi kundnöjdheten",
                Body = "Under mars månad genomförde vi en stor kundundersökning i alla våra butiker. Resultaten visar att bemötandet och kunskapen hos vår personal är det som kunderna uppskattar allra mest hos Sportson.",
                Author = "Butiksutvecklare Lisa Svensson",
                PublishedDate = new DateOnly(2026, 04, 09),
                Category = "Min butik",
                ImageUrl = "https://sportsonnews.blob.core.windows.net/sportsonnews/Minbutik8.jpg"
            },
            new NewsArticle
            {
                Id = 9,
                Title = "Nya öppettider inför sommarsäsongen",
                Body = "Från och med den 1 maj utökar vi öppettiderna i samtliga butiker för att möta den ökade efterfrågan under sommarmånaderna. Lördagar och söndagar kommer att ha förlängda öppettider fram till slutet av augusti.",
                Author = "Butikschef Per Nilsson",
                PublishedDate = new DateOnly(2026, 04, 10),
                Category = "Min butik",
                ImageUrl = "https://sportsonnews.blob.core.windows.net/sportsonnews/Minbutik9.jpg"
            },
            new NewsArticle
            {
                Id = 10,
                Title = "Sommarkampanj: Gratis cykelhjälm vid köp av elcykel",
                Body = "Under maj och juni erbjuder vi en gratis cykelhjälm värd upp till 599 kr vid köp av valfri elcykel. Kampanjen gäller i samtliga Sportson-butiker och är ett sätt att uppmuntra säkrare cykling.",
                Author = "Marknadsteamet",
                PublishedDate = new DateOnly(2026, 04, 11),
                Category = "Campaign",
                ImageUrl = "https://sportsonnews.blob.core.windows.net/sportsonnews/Campaign10.png"
            }
            );
        }
    }
}
