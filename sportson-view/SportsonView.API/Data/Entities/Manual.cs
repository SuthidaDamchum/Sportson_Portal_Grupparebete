namespace SportsonView.API.Data.Entities
{
    public class Manual
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string? Description { get; set; } = "";
        public string Type { get; set; } = "";
        public string Url { get; set; } = "";
        public string category { get; set; } = "";
    }
}
