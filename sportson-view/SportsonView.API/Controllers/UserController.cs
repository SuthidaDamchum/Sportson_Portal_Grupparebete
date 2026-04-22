using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Dto;

namespace SportsonView.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

       [Authorize]
        [HttpGet("me")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var userIdClaim = User.FindAll(ClaimTypes.NameIdentifier)
                .Select(c => c.Value)
                .FirstOrDefault(v => int.TryParse(v, out _));

            if (string.IsNullOrEmpty(userIdClaim))
                return Unauthorized("User ID claim saknas.");

            if (!int.TryParse(userIdClaim, out var userId))
                return Unauthorized("Ogiltig user ID claim.");

            var user = await _userService.GetUserByIdAsync(userId);

            if (user == null)
                return NotFound();

            return Ok(new UserDataDto
            {
                Username = user.Username,
                Email = user.Email,
                Store = user.Store
            });
        }
    }
}