using AutoMapper;
using SportsonView.API.Data.Entities;
using SportsonView.API.Dto;

namespace SportsonView.API.Profiles
{
    public class ManualProfile : Profile
    {
        public ManualProfile()
        {
            CreateMap<Manual, ManualDto>();
        }
    }
}
