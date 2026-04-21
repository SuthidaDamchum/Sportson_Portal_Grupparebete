namespace SportsonView.API.Data.Entities
{
    public class NewsArticle
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateOnly PublishedDate { get; set; }
        public string Category { get; set; } = string.Empty;
        public string? ImageUrl { get; set; } = string.Empty;
    }
}
