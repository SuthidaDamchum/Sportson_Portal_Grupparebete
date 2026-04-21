using System.Globalization;
using AutoMapper;
using SportsonView.API.Data.Entities;
using SportsonView.API.Dto;

namespace SportsonView.API.Profiles
{
    public class ImportantDateProfile : Profile
    {
        public ImportantDateProfile()
        {
            CreateMap<ImportantDate, ImportantDateDto>()

            .ForMember(dest => dest.Month, opt => opt.MapFrom(src => src.StartDate.ToString("MMMM", new CultureInfo("sv-SE"))))

            .ForMember(dest => dest.DateDisplay, opt => opt.MapFrom(src =>
                src.EndDate.HasValue
                ? $"{src.StartDate.Day}-{src.EndDate.Value.Day}"
                : src.StartDate.Day.ToString()))
            .ForMember(dest => dest.Time, opt => opt.MapFrom(src => src.TimeLabel));

        }
    }
}

