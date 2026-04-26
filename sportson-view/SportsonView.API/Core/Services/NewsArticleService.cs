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

    }
}


