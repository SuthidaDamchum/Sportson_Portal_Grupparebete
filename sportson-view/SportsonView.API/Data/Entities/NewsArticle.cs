using System.ComponentModel.DataAnnotations.Schema;

namespace SportsonView.API.Data.Entities
{
    public class NewsArticle
    {
        public NewsArticle(int id, string title, string body, string author, DateOnly publishedDate, string category, string imageUrl)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishedDate = publishedDate;
            Category = category;
            ImageUrl = imageUrl;

        }

        public int Id { get; set; }
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Body { get; set; }
        public string Author { get; set; }
        public DateOnly PublishedDate { get; set; }
        public string Category { get; set; }
        public string? ImageUrl { get; set; }

    }
}
