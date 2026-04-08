namespace SportsonView.API.Data.Entities
{
    public class NewsArticle
    {
        public NewsArticle(int id, string title, string body, string author, int publishedDate, CategoryEnum category)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishedDate = publishedDate;
            Category = category;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public int PublishedDate { get; set; }
        public CategoryEnum Category { get; set; }
      
      
    }
}
