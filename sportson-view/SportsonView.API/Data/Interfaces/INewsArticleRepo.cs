using SportsonView.API.Data.Entities;

namespace SportsonView.API.Data.Interfaces
{
    public interface INewsArticleRepo
    {
        Task<List<NewsArticle>> GetNewsAsync();
        Task<bool> DeleteNewsAsync(Guid id);

        void AddNewsArticleAsync(NewsArticle newsArticle);
    }
}
