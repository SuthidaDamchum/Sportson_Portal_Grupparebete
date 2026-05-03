using SportsonView.API.Data.Entities;

namespace SportsonView.API.Data.Interfaces
{
    public interface ISupportRepository
    {
        Task<bool> SendSupportMessageAsync(string username, string? store, string email, string department, string message);
    }
}