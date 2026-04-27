using SportsonView.API.Data.Entities;

namespace SportsonView.API.Core.Interfaces
{
    public interface ISupportService
    {
        Task<bool> SendSupportMessage(string username, string? store,string email, string department, string message);
    }
}