namespace SportsonView.API.Dto
{
    public class ImportantDateDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string DateDisplay { get; set; } = string.Empty;
        public string Month { get; set; } = string.Empty;       
        public string Time { get; set; } = string.Empty;       
    }
}

