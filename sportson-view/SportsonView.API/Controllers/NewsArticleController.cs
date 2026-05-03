using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsonView.API.Controllers.Response;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Core.Services;
namespace SportsonView.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NewsArticleController : ControllerBase
    {
        private readonly INewsArticleService _newsService;
        private readonly FileService _fileService;
        public NewsArticleController(INewsArticleService newsService, FileService fileService)
        {
            _newsService = newsService;
            _fileService = fileService;
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetNewsArticlesAsync([FromQuery] string? category)
        {
            var articles = await _newsService.GetNewsArticlesAsync(category);
            return Ok(new NewsArticleResponse { NewsArticles = articles });
        }

     

        
    }
}