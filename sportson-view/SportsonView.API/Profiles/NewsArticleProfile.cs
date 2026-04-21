using AutoMapper;
using SportsonView.API.Data.Entities;
using SportsonView.API.Dto;
namespace SportsonView.API.Profiles
{
    public class NewsArticleProfile : Profile
    {
        public NewsArticleProfile()
        {
            CreateMap<NewsArticle, NewsArticleDto>();
            // For reverse mapping (if needed), unused in this case
            CreateMap<NewsArticleDto, NewsArticle>();
        }
    }
}
