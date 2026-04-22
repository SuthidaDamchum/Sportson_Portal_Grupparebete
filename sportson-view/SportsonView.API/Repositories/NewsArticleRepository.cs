using Microsoft.EntityFrameworkCore;
using SportsonView.API.Data;
using SportsonView.API.Data.Configurations;
using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;

namespace SportsonView.API.Repositories
{
    public class NewsArticleRepository : INewsArticleRepository
    {
        private readonly ApplicationDbContext _context;
        public NewsArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<NewsArticle>> GetNewsArticlesAsync()
        {
            return await _context.NewsArticles.ToListAsync();
        }

        /// <summary>
        /// Används ej
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteNewsArticleAsync(int id)
        {
            var articleToRemove = await _context.NewsArticles.FirstOrDefaultAsync(a => a.Id == id);

            if (articleToRemove == null)
            {
                return false;
            }

            _context.Remove(articleToRemove);
            _context.SaveChanges();
            return true;
        }

        public async Task AddNewsArticleAsync(NewsArticle newsArticle)
        {
            _context.Add(newsArticle);
            _context.SaveChanges();
        }

        public async Task<NewsArticle?> UpdateNewsArticleAsync(int id, NewsArticle updatedNewsArticle)
        {
            var existing = await _context.NewsArticles.FirstOrDefaultAsync(a => a.Id == id);

            if (existing == null) return null;

            existing.Title = updatedNewsArticle.Title;
            existing.Body = updatedNewsArticle.Body;
            existing.Author = updatedNewsArticle.Author;
            existing.PublishedDate = updatedNewsArticle.PublishedDate;
            existing.Category = updatedNewsArticle.Category;
            existing.ImageUrl = updatedNewsArticle.ImageUrl;

            await _context.SaveChangesAsync();
            return existing;
        }
    }
}




