using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Data;
using Microsoft.EntityFrameworkCore;

namespace SportsonView.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserAsync(string username, string password)
        {
            return await _context.Users
                .Where(u => u.Username == username && u.Password == password)
                .FirstOrDefaultAsync();
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            return await _context.Users
                .Where(u => u.Username == username)
                .FirstOrDefaultAsync();
        }
        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}