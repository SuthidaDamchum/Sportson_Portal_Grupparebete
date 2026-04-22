using Microsoft.EntityFrameworkCore;
using SportsonView.API.Data.Configurations;
using SportsonView.API.Data.Entities;

namespace SportsonView.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
        {
        }
        public DbSet<NewsArticle> NewsArticles { get; set; }
        public DbSet<ImportantDate> ImportantDates { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new NewsArticleConfiguration());
            modelBuilder.ApplyConfiguration(new ImportantDateConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}