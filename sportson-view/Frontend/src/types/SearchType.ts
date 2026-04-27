export type SearchType = "Youtube" | "PDF";

export type SearchResult = {
  id: number;
  type: SearchType;
  title: string;
  description: string;
  category: string;
  URL: string;
};
