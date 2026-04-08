using System.Globalization;
using SportsonView.API.Data.Entities;
using SportsonView.API.Dto;

namespace SportsonView.API.Core.Interfaces
{
    public interface INewsArticleService
    {
        Task<List<NewsArticleDto>> GetNewsAsync();
        Task<bool> DeleteNewsAsync(Guid id);

        void AddNewsArticleAsync(NewsArticle newsArticle);
    }
}
