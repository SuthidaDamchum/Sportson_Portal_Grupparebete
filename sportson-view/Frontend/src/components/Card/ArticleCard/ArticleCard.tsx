import type { Article } from "../../../types/ArticleType";
import "./ArticleCard.css";

type ArticleCardProps = {
  article: Article;
};

const formatPublishDate = (publishedDate: string) => {
  return new Date(publishedDate).toLocaleDateString("sv-SE", {
    year: "numeric",
    month: "2-digit",
    day: "2-digit",
  });
};

const ArticleCard = ({ article }: ArticleCardProps) => {
  const imageUrl = article.imageUrl ?? "";
  const hasImage = imageUrl.trim().length > 0;

  return (
    <article className="article-card">
      <div className="article-image-wrap">
        {hasImage && <img src={imageUrl} className="article-image" />}
      </div>

      <div className="article-content">
        <div className="article-kicker">
          <span>{article.category}</span>
          <time dateTime={new Date(article.publishedDate).toISOString()}>
            {formatPublishDate(article.publishedDate)}
          </time>
        </div>

        <h2 className="article-title">{article.title}</h2>
        <p className="article-body" style={{ whiteSpace: "pre-line" }}>
          {article.body}
        </p>

        <div className="article-meta">
          <span>{article.author}</span>
        </div>
      </div>
    </article>
  );
};

export default ArticleCard;
