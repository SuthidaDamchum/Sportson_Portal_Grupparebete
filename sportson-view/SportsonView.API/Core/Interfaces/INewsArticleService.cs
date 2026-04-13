using SportsonView.API.Dto;

namespace SportsonView.API.Core.Interfaces
{
    public interface INewsArticleService

    {
        Task<List<NewsArticleDto>> GetNewsArticlesAsync();
        Task AddNewsArticleAsync(NewsArticleDto newsArticleDto);
        Task<NewsArticleDto?> UpdateNewsArticleAsync(int id, NewsArticleDto newsArticleDto);
        Task<bool> DeleteNewsArticleAsync(int id);
    }
}

