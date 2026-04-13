
using AutoMapper;
using SportsonView.API.Data.Entities;
using SportsonView.API.Dto;
namespace SportsonView.API.Profiles
{
    public class NewsArticleProfile : Profile
    {
        //Detta är ett mappningsschema som mappar en entitetsklass med en DTO klass

        public NewsArticleProfile()
        {
            // Från Databas-Entitet till DTO (för GET-anrop)
            CreateMap<NewsArticle, NewsArticleDto>();
            // Från DTO till Databas-Entitet (för POST/PUT-anrop)
            CreateMap<NewsArticleDto, NewsArticle>().ConstructUsing(dto => new NewsArticle(
                dto.Id,
                dto.Title,
                dto.Body,
                dto.Author,
                dto.PublishedDate,
                dto.Category,
                dto.ImageUrl 
            ));


        }
    }
}


