namespace SportsonView.API.Dto
{
    public class ImportantDateDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string DateDisplay { get; set; } = string.Empty; // T.ex. "26-29" eller "31"
        public string Month { get; set; } = string.Empty;       // T.ex. "Januari"
        public string Time { get; set; } = string.Empty;        // T.ex. "Hela dagen"
    }
}
