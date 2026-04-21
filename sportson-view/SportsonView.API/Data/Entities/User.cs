using System.ComponentModel.DataAnnotations.Schema;

namespace SportsonView.API.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Store { get; set; }
    }
}
