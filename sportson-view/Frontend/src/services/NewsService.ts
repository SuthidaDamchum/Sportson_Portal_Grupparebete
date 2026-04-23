import axios from "axios";
import type { Article } from "../types/ArticleType";
import { authService } from "./AuthService";

export type NewsResponse = { newsArticles: Article[] };

export const getNews = async (): Promise<Article[]> => {
  try {
    const token = authService.getToken();
    const response = await axios.get<NewsResponse>(
      "https://localhost:5001/api/NewsArticle/All",
      {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      },
    );
    return response.data.newsArticles || []; // ← ändra från news
  } catch (error) {
    console.error("Kunde inte nå API:", error);
    return [];
  }
};
