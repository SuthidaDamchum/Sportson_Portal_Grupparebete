using Microsoft.AspNetCore.Mvc;
using SportsonView.API.Controllers.Response;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Data.Entities;

namespace SportsonView.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsArticleController : ControllerBase
    {
        private readonly INewsArticleService _newsService;


        public NewsArticleController(INewsArticleService newsService)
        {
            _newsService = newsService;

        }

        [HttpGet("")]
        public async Task<IActionResult> GetNewsAsync()
        {
            return Ok(new NewsArticleResponse { NewsArticles = await _newsService.GetNewsAsync() });
        }

        [HttpPost("")]
        public async Task<IActionResult> AddNewsArticle(NewsArticle newsarticle)
        {
            _newsService.AddNewsArticleAsync(newsarticle);
            return Ok(newsarticle);


        }
            

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNews(Guid id)
        {
            var result = await _newsService.DeleteNewsAsync(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();


        }
    }
}