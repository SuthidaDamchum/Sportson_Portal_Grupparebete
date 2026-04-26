using SportsonView.API.Data.Entities;

namespace SportsonView.API.Data.Interfaces
{
    public interface INewsArticleRepository
    {
        Task<List<NewsArticle>> GetNewsArticlesAsync();
        
    }
}