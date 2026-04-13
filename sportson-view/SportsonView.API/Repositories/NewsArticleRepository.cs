using Microsoft.EntityFrameworkCore;
using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;


namespace SportsonView.API.Repos
{
    public class NewsArticleRepository : INewsArticleRepository
    {
        private readonly NewsArticleDbContext _context;

        public async Task SeedDataAsync()
        {
            var articles = new List<NewsArticle>
    {
        new NewsArticle(0, "Uppdatering av intranätet",
            "Vi har uppgraderat säkerheten i vår inloggning...",
            "Daniel Andersson", new DateOnly(2026, 04, 01), "IT", "https://sportsonsbilder.blob.core.windows.net/news-images/IT.png"),

        new NewsArticle(0, "Leveransförseningar elcyklar",
            "På grund av globala logistikproblem...",
            "Sara Lindberg", new DateOnly(2026, 04, 02), "Inköp", "https://sportsonsbilder.blob.core.windows.net/news-images/Inköp.png"),

        new NewsArticle(0, "Vårkampanjen drar igång!",
            "Nu är det officiellt...",
            "Erik Markström", new DateOnly(2026, 04, 03), "Marknad", "https://sportsonsbilder.blob.core.windows.net/news-images/Marknad.png"),

        new NewsArticle(0, "Nya krav på certifiering",
            "Från 1 maj inför vi nya krav...",
            "Mikael Verkstadsson", new DateOnly(2026, 04, 04), "Verkstad", "https://sportsonsbilder.blob.core.windows.net/news-images/Verkstad.png"),
            
        new NewsArticle(0, "Vårkampanj: 20% på alla Elcyklar!",
            "Gör dig redo för cykelsäsongen!...",
            "Marknadsteamet", new DateOnly(2026, 04, 12), "Campaign", "https://sportsonsbilder.blob.core.windows.net/news-images/Campaign.png")
    };

            _context.NewsArticles.AddRange(articles);

            await _context.SaveChangesAsync();
    }

        public NewsArticleRepository(NewsArticleDbContext context)
        {
            _context = context;
        }

        public async Task<List<NewsArticle>> GetNewsArticlesAsync()
        {
            return await _context.NewsArticles.ToListAsync();
        }
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




