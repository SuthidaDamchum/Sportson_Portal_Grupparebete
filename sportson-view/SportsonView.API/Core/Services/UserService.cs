using AutoMapper;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Data.Entities;

namespace SportsonView.API.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<User?> GetUserAsync(string username, string password)
        {
            var user = await _userRepository.GetUserAsync(username, password);
            return user;
        }

        public async Task<User?> AuthenticateUserAsync(string username, string plainPassword)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user == null)
                return null;

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(plainPassword, user.Password);

            return isPasswordValid ? user : null;
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }
    }
}