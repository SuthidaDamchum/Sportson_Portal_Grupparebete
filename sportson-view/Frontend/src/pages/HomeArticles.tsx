import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import type { Article } from "../types/ArticleType";
import { getArticle } from "../services/ArticleService";
import { routePaths } from "../services/RouteService";
import "./HomeArticles.css";
import { useUser } from "../context/UserContext";

const HomeNewsSection = () => {
  const { user } = useUser();
  const [articles, setArticles] = useState<Article[]>([]);
  const navigate = useNavigate();

  useEffect(() => {
    getArticle()
      .then((data) => {
        if (data && data.length > 0) {
          setArticles(data.slice(0, 4));
        }
      })
      .catch(() => {});
  }, []);

  if (!user) return null;

  return (
    <section className="home-news">
      <div className="home-news-header">
        <h2 className="home-news-title">Nyheter</h2>
        <button
          className="home-news-link"
          onClick={() => navigate(routePaths.news)}
        >
          Visa alla nyheter →
        </button>
      </div>

      <div className="home-news-list">
        {articles.map((article) => (
          <div
            key={article.id}
            className="home-news-item"
            onClick={() => navigate(routePaths.news)}
          >
            <img
              src={article.imageUrl}
              alt={article.title}
              className="home-news-image"
            />
            <div className="home-news-content">
              <div className="home-news-meta">
                <span className="home-news-item-title">{article.title}</span>
                <span className="home-news-date">{article.publishedDate}</span>
              </div>
              <p className="home-news-description">{article.description}</p>
            </div>
            <span className="home-news-arrow">›</span>
          </div>
        ))}
      </div>
    </section>
  );
};

export default HomeNewsSection;
