using SportsonView.API.Data.Entities;

namespace SportsonView.API.Data.Interfaces
{
    public interface INewsArticleRepository
    {
        Task<List<NewsArticle>> GetNewsArticlesAsync();
        Task<bool> DeleteNewsArticleAsync(int id);
        Task AddNewsArticleAsync(NewsArticle newsArticle);
        Task<NewsArticle?> UpdateNewsArticleAsync(int id, NewsArticle newsArticle);
    }
}