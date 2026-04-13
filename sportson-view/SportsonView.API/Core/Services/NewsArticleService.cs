using AutoMapper;
using SportsonView.API.Core.Interfaces;
using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;
using SportsonView.API.Dto;

namespace SportsonView.API.Core.Services
{
    public class NewsArticleService : INewsArticleService

    {
        private readonly IMapper _mapper;
        private readonly INewsArticleRepository _newsRepo;

        public NewsArticleService(INewsArticleRepository newsRepo, IMapper mapper)
        {
            _mapper = mapper;
            _newsRepo = newsRepo;
        }

        public async Task<List<NewsArticleDto>> GetNewsArticlesAsync()
        {
            var newsarticles = await _newsRepo.GetNewsArticlesAsync();
            return _mapper.Map<List<NewsArticleDto>>(newsarticles);
        }

        public async Task<bool> DeleteNewsArticleAsync(int id)
        {
            var success = await _newsRepo.DeleteNewsArticleAsync(id);
            return success;
        }

        public async Task AddNewsArticleAsync(NewsArticleDto newsArticleDto)
        {
            var entity = _mapper.Map<NewsArticle>(newsArticleDto);
            await _newsRepo.AddNewsArticleAsync(entity);
        }

        public async Task<NewsArticleDto?> UpdateNewsArticleAsync(int id, NewsArticleDto updatedArticleDto)
        {
     
            var entity = _mapper.Map<NewsArticle>(updatedArticleDto);

            var updatedEntity = await _newsRepo.UpdateNewsArticleAsync(id, entity);
            if (updatedEntity == null) return null;
            return _mapper.Map<NewsArticleDto>(updatedEntity);

        }

    }
}


