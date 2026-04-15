using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsonView.API.Controllers.Response;
using SportsonView.API.Core.Interfaces;

namespace SportsonView.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportantDateController : ControllerBase
    {
        private readonly IImportantDatesService _importantDatesService;
        public ImportantDateController(IImportantDatesService importantDatesService)
        {
            _importantDatesService = importantDatesService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllImportantDatesAsync()
        {
            var importantDates = await _importantDatesService.GetAllImportantDatesAsync();
            return Ok(new ImportantDateResponse { ImportantDates = importantDates });
        }

    }
}
