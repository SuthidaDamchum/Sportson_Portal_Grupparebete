using System.ComponentModel.DataAnnotations.Schema;

namespace SportsonView.API.Data.Entities
{
    public class NewsArticle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateOnly PublishedDate { get; set; }
        public string Category { get; set; }
        public string? ImageUrl { get; set; }
    }
}
