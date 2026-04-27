using Microsoft.EntityFrameworkCore;
using SportsonView.API.Data;
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
        public async Task<List<NewsArticle>> GetNewsArticlesAsync(string? category)
        {
            Console.WriteLine($"Category filter: {category}");

            return await _context.NewsArticles
                .Where(na => string.IsNullOrEmpty(category) || na.Category == category)
                .ToListAsync();

        }
       
    }
}




