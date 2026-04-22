export type Article = {
  id: number;
  title: string;
  body: string;
  author: string;
  publishedDate: string;
  category: string;
  imageUrl: string;
};

// export async function getArticles(): Promise<Article[]> {
//   const res = await fetch("/api/articles");
//   if (!res.ok) throw new Error("Failed to fetch articles");
//   return res.json();
// }

