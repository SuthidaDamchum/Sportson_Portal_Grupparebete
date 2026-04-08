using AutoMapper;
using SportsonView.API.Controllers;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Dto;

namespace SportsonView.API.Core.Services
{
    public class NewsArticleService : INewsArticleService

    { 
        private readonly IMapper _mapper;
        private readonly INewsArticleRepo _newsRepo;

        public NewsArticleService(INewsArticleRepo newsRepo, IMapper mapper)
        {
            _mapper = mapper;
            _newsRepo = newsRepo;
        }

        public async Task<List<NewsArticleDto>> GetNewsAsync()
        {
             var newsarticles = await _newsRepo.GetNewsAsync();
            return newsarticles.Select(article => _mapper.Map<NewsArticleDto>(article)).ToList();
        }

        public async Task<bool> DeleteNewsAsync(Guid id)
        {
            var success = await _newsRepo.DeleteNewsAsync(id);
            return success;
        }

        public void AddNewsArticleAsync(NewsArticle newsArticle)
        {
            _newsRepo.AddNewsArticleAsync(newsArticle);
        }



    }
}
