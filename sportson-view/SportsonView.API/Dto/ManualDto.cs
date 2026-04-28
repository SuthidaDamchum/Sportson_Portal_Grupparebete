namespace SportsonView.API.Dto
{
    public class ManualDto
    {
         public int Id { get; set; } 
        public string Title { get; set; } = "";
        public string? Description { get; set; } = "";
        public string Type { get; set; } = "";
        public string Url { get; set; } = "";
        public string category { get; set; } = "";
    }
}
