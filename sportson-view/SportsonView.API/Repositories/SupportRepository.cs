using SportsonView.API.Data.Interfaces;

namespace SportsonView.API.Repositories
{
    public class SupportRepository : ISupportRepository
    {
        public Task<bool> SendSupportMessageAsync(string username, string? store, string email, string department, string message)
        {
            return Task.FromResult(true);
        }
    }
}