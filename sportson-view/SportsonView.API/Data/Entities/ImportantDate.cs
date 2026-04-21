namespace SportsonView.API.Data.Entities
{
    public class ImportantDate
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty; 
        public DateTime StartDate { get; set; } 
        public DateTime? EndDate { get; set; }   
        public string TimeLabel { get; set; } = string.Empty; 
        public bool IsReminderActive { get; set; } 
    }
}