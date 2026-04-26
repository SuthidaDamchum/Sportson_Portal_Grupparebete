using Microsoft.AspNetCore.Mvc;
using SportsonView.API.Controllers.Response;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Core.Services;
using SportsonView.API.Dto;
namespace SportsonView.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task<IActionResult> GetNewsArticlesAsync()
        {
            var articles = await _newsService.GetNewsArticlesAsync();
            return Ok(new NewsArticleResponse { NewsArticles = articles });
        }
    }
}