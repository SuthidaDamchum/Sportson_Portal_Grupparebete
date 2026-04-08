
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
            //Destination här är PersonDTO och origin är Person
            //dvs vi mappar från Person till PersonDTO

            CreateMap<NewsArticle, NewsArticleDto>();
            CreateMap<NewsArticleDto, NewsArticle>();



        }

    }
}


