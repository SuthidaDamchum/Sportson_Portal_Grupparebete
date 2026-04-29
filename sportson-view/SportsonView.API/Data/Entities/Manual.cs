namespace SportsonView.API.Data.Entities;

public class Manual ()
{
   public int Id { get; set; } 
   public string Title { get; set; } = string.Empty;
   public string Type { get; set; } = string.Empty;
   public string URL { get; set; } = string.Empty;
   public string? Description { get; set; } = string.Empty;

}