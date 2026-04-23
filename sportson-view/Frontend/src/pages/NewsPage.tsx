import { useEffect, useState } from "react";
import ArticleCard from "../components/Card/ArticleCard/ArticleCard";
import type { Article } from "../types/ArticleType";
import { getNews } from "../services/NewsService";

const placeholderArticles: Article[] = [
  {
    id: 1,
    title: "Uppdatering av intranätet och IT-säkerhet",
    body: "Som en del i vårt kontinuerliga arbete med att stärka säkerheten kring företagets digitala tillgångar, kommer vi att genomföra en stor uppgradering av inloggningssystemet...",
    author: "Daniel Andersson",
    publishedDate: "2026-04-01",
    category: "IT",
    imageUrl: "https://sportsonnews.blob.core.windows.net/sportsonnews/It1.png",
  },
  {
    id: 2,
    title: "Leveransförseningar av årets elcyklar",
    body: "Vi har tyvärr mottagit tråkiga besked från våra logistikpartners gällande de kommande leveranserna av elcyklar från Crescent och Monark...",
    author: "Sara Lindberg",
    publishedDate: "2026-04-02",
    category: "Inköp",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Inkop2.webp",
  },
  {
    id: 3,
    title: "Vårkampanjen 2026 drar äntligen igång!",
    body: "Nu är det äntligen dags att rulla ut årets absolut största och viktigaste kampanj, vår stora vårstart som kickar igång cykelsäsongen på allvar...",
    author: "Erik Markström",
    publishedDate: "2026-04-03",
    category: "Marknad",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Marknad3.png",
  },
  {
    id: 4,
    title: "Ny verktygspark installerad i samtliga butiker",
    body: "För att bibehålla vår status som auktoriserad servicepartner för Shimano, inför vi nu skärpta krav på certifiering för all verkstadspersonal...",
    author: "Mikael Verkstadsson",
    publishedDate: "2026-04-04",
    category: "Verkstad",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Verkstad4.png",
  },
  {
    id: 5,
    title: "Vårkampanj: 20% rabatt på alla Elcyklar i lager!",
    body: "Gör dig redo för den ultimata cykelsäsongen med vårt största erbjudande någonsin på marknadens absolut bästa och mest moderna elcyklar...",
    author: "Marknadsteamet",
    publishedDate: "2026-04-12",
    category: "Campaign",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Kampanj5.png",
  },
  {
    id: 6,
    title: "Årets resultat överträffar alla förväntningar",
    body: "Vi är glada att meddela att Sportson redovisar ett rekordresultat för det första kvartalet 2026. Omsättningen ökade med 18% jämfört med samma period förra året tack vare starka cykelförsäljningar och ökad efterfrågan på service...",
    author: "CFO Anna Bergström",
    publishedDate: "2026-04-05",
    category: "Ekonomi",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Ekonomi6.jpeg",
  },
  {
    id: 7,
    title: "Budgetgenomgång inför hösten 2026",
    body: "Ekonomiavdelningen bjuder in alla butikschefer till en digital budgetgenomgång den 25 april. Vi går igenom prognos för Q2 och planerar inför den viktiga höstsäsongen med fokus på lönsamhet och kostnadseffektivitet...",
    author: "Anna Bergström",
    publishedDate: "2026-04-08",
    category: "Ekonomi",
    imageUrl:
      " https://sportsonnews.blob.core.windows.net/sportsonnews/Ekonomi7.png",
  },
  {
    id: 8,
    title: "Min butik: Så ökar vi kundnöjdheten",
    body: "Under mars månad genomförde vi en stor kundundersökning i alla våra butiker. Resultaten visar att bemötandet och kunskapen hos vår personal är det som kunderna uppskattar allra mest hos Sportson...",
    author: "Butiksutvecklare Lisa Svensson",
    publishedDate: "2026-04-09",
    category: "Min butik",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonnews/Minbutik8.jpg",
  },
  {
    id: 9,
    title: "Nya öppettider inför sommarsäsongen",
    body: "Från och med den 1 maj utökar vi öppettiderna i samtliga butiker för att möta den ökade efterfrågan under sommarmånaderna. Lördagar och söndagar kommer att ha förlängda öppettider fram till slutet av augusti...",
    author: "Butikschef Per Nilsson",
    publishedDate: "2026-04-10",
    category: "Min butik",
    imageUrl:
      " https://sportsonnews.blob.core.windows.net/sportsonnews/Minbutik9.jpg",
  },
  {
    id: 10,
    title: "Sommarkampanj: Gratis cykelhjälm vid köp av elcykel",
    body: "Under maj och juni erbjuder vi en gratis cykelhjälm värd upp till 599 kr vid köp av valfri elcykel. Kampanjen gäller i samtliga Sportson-butiker och är ett sätt att uppmuntra säkrare cykling...",
    author: "Marknadsteamet",
    publishedDate: "2026-04-11",
    category: "Campaign",
    imageUrl:
      " https://sportsonnews.blob.core.windows.net/sportsonnews/Campaign10.png",
  },
];

const NewsPage = () => {
  const [articles, setArticles] = useState<Article[]>(placeholderArticles);

  useEffect(() => {
    getNews()
      .then((data) => {
        if (data && data.length > 0) {
          console.log("Data från backend:", data);
          setArticles(data);
        } else {
          console.log("Backend tom , använder mockdata");
        }
      })
      .catch((err) => {
        console.log("Backend fel , använder mockdata:", err);
      });
  }, []);

  return (
    <div className="view" style={{ padding: "28px" }}>
      <h1>Nyheter</h1>
      <div
        style={{
          display: "grid",
          gridTemplateColumns: "repeat(auto-fill, minmax(300px, 1fr))",
          gap: "24px",
        }}
      >
        {articles.map((article) => (
          <ArticleCard key={article.id} article={article} />
        ))}
      </div>
    </div>
  );
};
export default NewsPage;
