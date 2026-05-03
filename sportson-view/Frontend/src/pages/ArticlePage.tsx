import { useEffect, useState } from "react";
import ArticleCard from "../components/Card/ArticleCard/ArticleCard";
import type { Article } from "../types/ArticleType";
import { getArticle } from "../services/ArticleService";
import ArticleModal from "./ArticleModal";
import "./ArticlePage.css";

const placeholderArticles: Article[] = [
  {
    id: 1,
    title: "Uppdatering av intranätet och IT-säkerhet",
    description:
      "Från måndag krävs tvåfaktorsautentisering för alla anställda. Ladda ner Microsoft Authenticator redan idag.",
    body: "Som en del i vårt kontinuerliga arbete med att stärka säkerheten kring företagets digitala tillgångar, kommer vi att genomföra en stor uppgradering av inloggningssystemet. Från och med måndag nästa vecka krävs tvåfaktorsautentisering (2FA) för samtliga anställda som arbetar på huvudkontoret och i våra butiker. Detta innebär att du utöver ditt vanliga lösenord även behöver bekräfta din identitet via Microsoft Authenticator-appen på din arbetstelefon. Vi har sett en ökad mängd nätfiskeförsök mot liknande företag i branschen och väljer därför att ligga steget före för att skydda vår data. Vi rekommenderar alla att ladda ner appen redan idag och följa den steg-för-steg-guide som finns publicerad på startsidan under IT-support. Om du saknar en arbetstelefon eller har problem med att installera applikationen, vänligen kontakta helpdesk senast fredag kl 15:00. Det nya systemet kommer även att göra det enklare att nå våra interna system hemifrån på ett säkert sätt utan att använda krångliga VPN-lösningar. Vid första inloggningen på måndag kommer du att mötas av en installationsguide som tar ungefär två minuter att genomföra helt på egen hand.",
    author: "Daniel Andersson",
    publishedDate: new Date().toISOString().split("T")[0],
    category: "IT",
    imageUrl: "https://sportsonnews.blob.core.windows.net/sportsonnews/It1.png",
  },
  {
    id: 2,
    title: "Leveransförseningar av årets elcyklar",
    description:
      "Leveransen av årets elcyklar från Crescent och Monark försenas med två till tre veckor på grund av störningar i fraktkedjan.",
    body: "Vi har tyvärr mottagit tråkiga besked från våra logistikpartners gällande de kommande leveranserna av elcyklar från Crescent och Monark. På grund av oväntade störningar i den globala fraktkedjan och tillfällig brist på specifika växelkomponenter från Shimano, dröjer leveransen. Förseningen beräknas just nu vara cirka två till tre veckor från det ursprungliga datumet som kommunicerades ut till butikerna i mars. Detta påverkar främst våra mest populära pendlarmodeller, vilket är beklagligt då vi vet att många kunder väntar ivrigt på sina cyklar. Inköpsavdelningen arbetar dygnet runt med att hitta alternativa fraktvägar för att försöka korta ner väntetiden så mycket som det går. Vi ber alla butikssäljare att vara proaktiva och ringa upp de kunder som har lagt handpenning för att informera om det aktuella läget. För att kompensera de väntande kunderna har ledningen beslutat att vi erbjuder en gratis förstaårsservice till alla som drabbas av förseningen.",
    author: "Sara Lindberg",
    publishedDate: new Date().toISOString().split("T")[0],
    category: "Inköp",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Inkop2.webp",
  },
  {
    id: 3,
    title: "Vårkampanjen 2026 drar äntligen igång!",
    description:
      "Vårkampanjen startar 15 april med TV, radio och sociala medier. Nytt butiksmaterial levereras under veckan.",
    body: "Nu är det äntligen dags att rulla ut årets absolut största och viktigaste kampanj, vår stora vårstart som kickar igång cykelsäsongen på allvar. Marknadsavdelningen har under flera månader arbetat med att ta fram ett koncept som verkligen sticker ut i bruset och lockar folk till butik. Kampanjen startar officiellt den 15 april och kommer att synas stort i både TV, radio och i alla våra sociala mediekanaler under sex veckor. Vi har tagit fram helt nytt butiksmaterial i form av vepor, gatupratare och digitala banners som börjar levereras till er under veckan. Målet med årets kampanj är att visa på friheten med att cykla och hur enkelt det är att byta ut bilen mot en modern elcykel i vardagen. Vi vill uppmuntra alla butiker att planera in lokala provkörningsdagar under helgerna för att låta så många som möjligt testa våra nyheter.",
    author: "Erik Markström",
    publishedDate: new Date().toISOString().split("T")[0],
    category: "Marknad",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Marknad3.png",
  },
  {
    id: 4,
    title: "Ny verktygspark installerad i samtliga butiker",
    description:
      "Samtliga verkstäder har fått ny modern utrustning, inklusive diagnostikverktyg för elcyklar och specialverktyg för Shimano.",
    body: "Vi är glada att kunna meddela att Sportson nu har investerat i en helt ny och modern verktygspark till samtliga av våra verkstäder runt om i landet. Investeringen är en del av vår långsiktiga satsning på att hålla högsta möjliga servicekvalitet för våra kunder och deras cyklar. De nya verktygen inkluderar avancerade diagnostikverktyg för elcyklar, kalibrerade momentnycklar och specialverktyg för Shimano Di2- och EP8-systemen. Med den nya utrustningen kan våra mekaniker utföra service och reparationer snabbare, säkrare och med ännu högre precision än tidigare.",
    author: "Mikael Verkstadsson",
    publishedDate: new Date().toISOString().split("T")[0],
    category: "Verkstad",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Verkstad4.png",
  },
  {
    id: 5,
    title: "Vårkampanj: 20% rabatt på alla Elcyklar i lager!",
    description:
      "Just nu 20% rabatt på alla elcyklar i lager. Gäller Scott, Specialized, Trek och Crescent så långt lagret räcker.",
    body: "Gör dig redo för den ultimata cykelsäsongen med vårt största erbjudande någonsin på marknadens absolut bästa och mest moderna elcyklar. Just nu firar vi vårens ankomst med en fantastisk kampanj där vi erbjuder hela 20% rabatt på samtliga elcyklar som vi har i butikslagret. Oavsett om du letar efter en snabb pendlarcykel för jobbet, en robust lådcykel för familjen eller en kraftfull MTB, så har vi modellen. Erbjudandet gäller alla märken såsom Scott, Specialized, Trek och Crescent, men bara så långt lagret räcker i din lokala Sportson-butik. Vid köp av en ny elcykel ingår som alltid vår trygga livstidsgaranti på ramen och en kostnadsfri första säkerhetskontroll efter tre månader.",
    author: "Marknadsteamet",
    publishedDate: new Date().toISOString().split("T")[0],
    category: "Campaign",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Kampanj5.png",
  },
  {
    id: 6,
    title: "Årets resultat överträffar alla förväntningar",
    description:
      "Sportson redovisar rekordresultat för Q1 2026 med 18% ökad omsättning jämfört med samma period förra året.",
    body: "Vi är glada att meddela att Sportson redovisar ett rekordresultat för det första kvartalet 2026. Omsättningen ökade med 18% jämfört med samma period förra året tack vare starka cykelförsäljningar och ökad efterfrågan på service. Den starkaste tillväxten skedde inom segmentet elcyklar, där vi såg en ökning på hela 34% jämfört med Q1 2025. Även vår serviceverksamhet visade på god tillväxt, vilket bekräftar att vår satsning på välutbildad verkstadspersonal ger resultat. Ledningen är mycket nöjd med utvecklingen och ser positivt på resten av 2026 med en stark vårkampanj på gång.",
    author: "CFO Anna Bergström",
    publishedDate: new Date().toISOString().split("T")[0],
    category: "Ekonomi",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Ekonomi6.jpeg",
  },
  {
    id: 7,
    title: "Budgetgenomgång inför hösten 2026",
    description:
      "Butikschefer bjuds in till digital budgetgenomgång den 25 april inför höstens planering och Q2-prognos.",
    body: "Ekonomiavdelningen bjuder in alla butikschefer till en digital budgetgenomgång den 25 april. Vi går igenom prognos för Q2 och planerar inför den viktiga höstsäsongen med fokus på lönsamhet och kostnadseffektivitet. Under mötet kommer vi att gå igenom butikernas individuella resultat och jämföra med budget. Vi kommer även att presentera nya riktlinjer för personalkostnader och lagerhållning inför hösten. Kallelse med länk till Teams-mötet skickas ut till samtliga butikschefer senast den 22 april.",
    author: "Anna Bergström",
    publishedDate: new Date().toISOString().split("T")[0],
    category: "Ekonomi",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Ekonomi7.png",
  },
  {
    id: 8,
    title: "Min butik: Så ökar vi kundnöjdheten",
    description:
      "Kundundersökningen visar att bemötande och personalkännedom är det kunderna uppskattar mest hos Sportson.",
    body: "Under mars månad genomförde vi en stor kundundersökning i alla våra butiker. Resultaten visar att bemötandet och kunskapen hos vår personal är det som kunderna uppskattar allra mest hos Sportson. Hela 92% av de tillfrågade kunderna angav att de skulle rekommendera Sportson till en vän eller kollega. De områden där vi har störst förbättringspotential är väntetider i kassan och tillgänglighet på populära produkter. Vi kommer under Q2 att lansera ett nytt utbildningsprogram för all butikspersonal med fokus på kundmötet.",
    author: "Butiksutvecklare Lisa Svensson",
    publishedDate: new Date().toISOString().split("T")[0],
    category: "Min butik",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Minbutik8.jpg",
  },
  {
    id: 9,
    title: "Nya öppettider inför sommarsäsongen",
    description:
      "Från 1 maj utökas öppettiderna i alla butiker med förlängda helgöppettider fram till slutet av augusti.",
    body: "Från och med den 1 maj utökar vi öppettiderna i samtliga butiker för att möta den ökade efterfrågan under sommarmånaderna. Lördagar och söndagar kommer att ha förlängda öppettider fram till slutet av augusti. Vardagar öppnar vi kl 09:00 och stänger kl 19:00, medan helger gäller 10:00–17:00. Extra personal kommer att sättas in under helgerna för att säkerställa god service även under högtrycksperioder. Butikschefer ansvarar för att uppdatera sina respektive butikssidor på Google och sociala medier med de nya tiderna.",
    author: "Butikschef Per Nilsson",
    publishedDate: new Date().toISOString().split("T")[0],
    category: "Min butik",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Minbutik9.jpg",
  },
  {
    id: 10,
    title: "Sommarkampanj: Gratis cykelhjälm vid köp av elcykel",
    description:
      "Gratis cykelhjälm värd upp till 599 kr vid köp av valfri elcykel under maj och juni i samtliga butiker.",
    body: "Under maj och juni erbjuder vi en gratis cykelhjälm värd upp till 599 kr vid köp av valfri elcykel. Kampanjen gäller i samtliga Sportson-butiker och är ett sätt att uppmuntra säkrare cykling bland våra kunder. Hjälmen väljs ut av kunden i butik och registreras som en del av köpet i kassan med en specifik kampanjkod. Kampanjkoden och instruktioner för hur erbjudandet hanteras i kassan skickas ut till butikerna veckan innan start. Erbjudandet gäller inte i kombination med andra rabatter eller kampanjer om inget annat anges.",
    author: "Marknadsteamet",
    publishedDate: new Date().toISOString().split("T")[0],
    category: "Campaign",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Campaign10.png",
  },
];

const ArticlePage = () => {
  const [articles, setArticles] = useState<Article[]>(placeholderArticles);
  const [selectedArticle, setSelectedArticle] = useState<Article | null>(null);
  const [selectedCategory, setSelectedCategory] = useState<string>("Alla");

  const categories = ["Alla", ...new Set(articles.map((a) => a.category))];
  const filteredArticles =
    selectedCategory === "Alla"
      ? articles
      : articles.filter((a) => a.category === selectedCategory);

  useEffect(() => {
    getArticle()
      .then((data) => {
        if (data && data.length > 0) {
          console.log("DataNews från backend:", data);
          setArticles(data);
        } else {
          console.log("API News Backend tom , använder mockdata");
        }
      })
      .catch((err) => {
        console.log("API News Backend fel , använder mockdata:", err);
      });
  }, []);

  return (
    <div className="view">
      <div className="article-filter-bar">
        <span className="article-filter-label">Kategori:</span>
        {categories.map((cat) => (
          <button
            key={cat}
            onClick={() => setSelectedCategory(cat)}
            className={`category-btn ${selectedCategory === cat ? "active" : ""}`}
          >
            {cat}
          </button>
        ))}
      </div>

      <div
        style={{
          padding: "28px",
          display: "grid",
          gridTemplateColumns: "repeat(4, 1fr)",
          gap: "16px",
          alignItems: "stretch",
        }}
      >
        {filteredArticles.map((article) => (
          <ArticleCard
            key={article.id}
            article={article}
            onClick={() => setSelectedArticle(article)}
          />
        ))}
      </div>

      {selectedArticle && (
        <ArticleModal
          article={selectedArticle}
          onClose={() => setSelectedArticle(null)}
        />
      )}
    </div>
  );
};
export default ArticlePage;
