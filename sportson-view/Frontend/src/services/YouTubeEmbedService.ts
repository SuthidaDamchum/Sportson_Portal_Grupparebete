export const toYouTubeEmbedUrl = (url: string): string | null => {
  try {
    const parsedUrl = new URL(url);
    const host = parsedUrl.hostname.replace("www.", "");

    if (
      (host !== "youtube.com" && host !== "m.youtube.com") ||
      parsedUrl.pathname !== "/watch"
    ) {
      return null;
    }

    const videoId = parsedUrl.searchParams.get("v");
    if (!videoId) {
      return null;
    }

    return `https://www.youtube.com/embed/${videoId}`;
  } catch {
    return null;
  }
};
