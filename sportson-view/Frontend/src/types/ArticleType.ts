export type Article = {
  title: string;
  body: string;
  author: string;
  image: string;
  publishDate: number;
};

export async function getArticles(): Promise<Article[]> {
  const res = await fetch("/api/articles");
  if (!res.ok) throw new Error("Failed to fetch articles");
  return res.json();
}
