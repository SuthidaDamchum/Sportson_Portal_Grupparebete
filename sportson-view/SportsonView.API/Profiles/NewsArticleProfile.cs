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
            CreateMap<NewsArticleDto, NewsArticle>();
        }
    }
}