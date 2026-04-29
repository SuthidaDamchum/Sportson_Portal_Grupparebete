using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsonView.API.Controllers.Response;
using SportsonView.API.Core.Interfaces;

namespace SportsonView.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ManualController : ControllerBase
    {
        private readonly IManualService _manualService;

        public ManualController(IManualService manualService)
        {
            _manualService = manualService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetManuals([FromQuery] string? type, [FromQuery] string? search)
        {
            var manuals = await _manualService.GetAllAsync(type, search);
            return Ok(new ManualResponse { Manuals = manuals });
        }
    }
}

