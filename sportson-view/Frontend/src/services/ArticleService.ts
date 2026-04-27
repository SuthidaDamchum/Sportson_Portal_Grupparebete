import axios from "axios";
import type { Article } from "../types/ArticleType";
import { authService } from "./AuthService";

export type NewsResponse = { newsArticles: Article[] };

export const getArticle = async (): Promise<Article[]> => {
  try {
    const response = await axios.get<NewsResponse>("/api/NewsArticle/All", {
      headers: {
        Authorization: `Bearer ${authService.getToken()}`,
      },
    });
    return response.data.newsArticles || [];
  } catch (error) {
    console.error("Kunde inte nå NewsAPI:", error);
    return [];
  }
};
