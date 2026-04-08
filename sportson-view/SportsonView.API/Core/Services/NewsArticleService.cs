using SportsonView.API.Core.Interfaces;
using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;

namespace SportsonView.API.Core.Services
{
    public class NewsArticleService : INewsArticleService
    {
        private readonly INewsArticleRepo _newsRepo;

        public NewsArticleService(INewsArticleRepo newsRepo)
        {
            _newsRepo = newsRepo;
        }

        public async Task<List<NewsArticle>> GetNewsAsync()
        {
             return await _newsRepo.GetNewsAsync();
        }

        public async Task<bool> DeleteNewsAsync(int id)
        {
            var success = await _newsRepo.DeleteNewsAsync(id);
            return success;
        }

        public void AddNewsArticleAsync(NewsArticle newsArticle)
        {
            _newsRepo.AddNewsArticleAsync(newsArticle);
        }
    }
}
