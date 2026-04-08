namespace SportsonView.API.Data.Entities
{
    public class NewsArticle
    {
        public NewsArticle(Guid id, string title, string body, string author, int publishedDate, string category)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishedDate = publishedDate;
            Category = category;
        }

        // guid är mer industristandard nu förtiden, säkrare //Int mindre säkert och är begränsat i antal 
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public int PublishedDate { get; set; }
        public string Category { get; set; }
    }
}
