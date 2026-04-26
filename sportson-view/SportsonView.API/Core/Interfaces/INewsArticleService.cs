using SportsonView.API.Dto;

namespace SportsonView.API.Core.Interfaces
{
    public interface INewsArticleService

    {
        Task<List<NewsArticleDto>> GetNewsArticlesAsync();
    }
}

