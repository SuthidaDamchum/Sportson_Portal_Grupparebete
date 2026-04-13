using Microsoft.EntityFrameworkCore;
using SportsonView.API.Dto;

namespace SportsonView.API.Data.Entities
{
    public class NewsArticleDbContext : DbContext

    {

        public NewsArticleDbContext(DbContextOptions<NewsArticleDbContext> options)
            : base(options)
        {
        }

        public DbSet<NewsArticle> NewsArticles { get; set; }

    }
}
