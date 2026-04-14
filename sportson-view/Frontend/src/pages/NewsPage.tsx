import ArticleCard from "../components/Card/ArticleCard/ArticleCard";
import type { Article } from "../types/ArticleType";
import DoggeMedCykel from "../assets/images/DoggeMedCykel.webp";
import genericBikeImage from "../assets/images/genericbike.webp";

const placeholderArticles: Article[] = [
  {
    id: 1,
    title: "Nya vårkampanjen är live sammarbete med Dogge, Cykel på köpet!!!",
    description:
      "Detta är en placeholder-text för nyhetsinnehåll. När backend och databas är anslutna ersätts den här artikeln med riktig data.",
    author: "Sportson kampanjteam",
    publishDate: Date.now(),
    category: "inköp",
    imageUrl: DoggeMedCykel,
  },
  {
    id: 2,
    title: "KOLLA VILKEN FIN CYKEL!!!!",
    description: "Här kan en kort beskrivning visas.",
    author: "Sportson",
    publishDate: Date.now(),
    category: "Inköp",
    imageUrl: genericBikeImage,
  },
];

const NewsPage = () => {
  return (
    <div className="view" style={{ padding: "28px", maxWidth: "1160px" }}>
      <h1>Nyheter</h1>
      <div
        style={{
          display: "grid",
          gridTemplateColumns: "repeat(auto-fill, minmax(260px, 300px))",
          gap: "45px",
          justifyContent: "start",
        }}
      >
        {placeholderArticles.map((article) => (
          <ArticleCard
            key={`${article.title}-${article.publishDate}`}
            article={article}
          />
        ))}
      </div>
    </div>
  );
};
export default NewsPage;
