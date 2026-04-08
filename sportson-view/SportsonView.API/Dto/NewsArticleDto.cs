namespace SportsonView.API.Dto
{
    public class NewsArticleDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public int PublishedDate { get; set; }
        public string Category { get; set; }
    }
}
