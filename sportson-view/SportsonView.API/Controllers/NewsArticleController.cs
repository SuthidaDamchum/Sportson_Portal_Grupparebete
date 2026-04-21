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

        //De här nere är Fullständig CRUD, vi behöver bara Get eller Post 
        [HttpPost("")]
        public async Task<IActionResult> AddNewsArticleAsync([FromForm] NewsArticleDto newsArticleDto, IFormFile imageFile)
        {
            if (imageFile != null)
            {
                string imageUrl = await _fileService.UploadFileAsync(imageFile);
                newsArticleDto.ImageUrl = imageUrl;
            }

            await _newsService.AddNewsArticleAsync(newsArticleDto);
            return Ok(newsArticleDto);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteNewsArticleAsync(int id)
        {
            var result = await _newsService.DeleteNewsArticleAsync(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNewsArticleAsync(int id, [FromForm] NewsArticleDto updatedArticleDto, IFormFile? imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                string newImageUrl = await _fileService.UploadFileAsync(imageFile);
                updatedArticleDto.ImageUrl = newImageUrl;
            }

            var result = await _newsService.UpdateNewsArticleAsync(id, updatedArticleDto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }
    }
}