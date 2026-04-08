using System.Globalization;
using SportsonView.API.Data.Entities;

namespace SportsonView.API.Core.Interfaces
{
    public interface INewsArticleService
    {
        Task<List<NewsArticle>> GetNewsAsync();
        Task<bool> DeleteNewsAsync(int id);

        void AddNewsArticleAsync(NewsArticle newsArticle);
    }
}
