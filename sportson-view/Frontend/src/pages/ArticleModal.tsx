import type { Article } from "../types/ArticleType";
import "./ArticleModal.css";

type ArticleModalProps = {
  article: Article;
  onClose: () => void;
};

const formatPublishedDate = (publishedDate: string) => {
  return new Date(publishedDate).toLocaleDateString("sv-SE", {
    year: "numeric",
    month: "2-digit",
    day: "2-digit",
  });
};

const ArticleModal = ({ article, onClose }: ArticleModalProps) => {
  return (
    <div className="modal-overlay" onClick={onClose}>
      <div className="modal-content" onClick={(e) => e.stopPropagation()}>
        <button className="modal-close" onClick={onClose}>
          ✕
        </button>

        <img src={article.imageUrl} className="modal-image" />

        <div className="modal-body">
          <div className="modal-kicker">
            <span>{article.category}</span>
            <time>{formatPublishedDate(article.publishedDate)}</time>
          </div>

          <h2 className="modal-title">{article.title}</h2>
          <p className="modal-author">{article.author}</p>
          <p className="modal-body">{article.body}</p>
        </div>
      </div>
    </div>
  );
};

export default ArticleModal;
