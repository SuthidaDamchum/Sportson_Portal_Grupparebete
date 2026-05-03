namespace SportsonView.API.Data.Entities
{
    public class SupportRequest
    {
        public string Name { get; set; }
        public string? Store { get; set; }
        public string FromEmail { get; set; }
        public string Department { get; set; }
        public string Message { get; set; }
    }
}