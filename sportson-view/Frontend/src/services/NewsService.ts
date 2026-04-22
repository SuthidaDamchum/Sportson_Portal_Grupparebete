
import axios from "axios";
import type{ Article } from "../types/ArticleType";

export type NewsResponse = { newsArticles: Article[] };

export const getNews = async (): Promise<Article[]> => {
  try {
    const response = await axios.get<NewsResponse>(
      "http://localhost:5178/api/newsarticle/all"
    );
    return response.data.newsArticles || []; // ← ändra från news
  } catch (error) {
    console.error("Kunde inte nå API:", error);
    return [];
  }
};