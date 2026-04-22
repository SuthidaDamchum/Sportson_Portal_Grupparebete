using SportsonView.API.Data.Entities;

namespace SportsonView.API.Core.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetUserAsync(string username, string password);
        Task<User?> AuthenticateUserAsync(string username, string plainPassword);
        Task<User?> GetUserByIdAsync(int id);
    }
}