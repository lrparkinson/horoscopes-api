using AutoMapper;
using totally_legit_horoscopes_api.DTOs;
using totally_legit_horoscopes_api.Models;

namespace totally_legit_horoscopes_api.Services.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StarSign, StarSignDTO>();
            CreateMap<StarSignMatch, StarSignMatchDTO>();
            CreateMap<Hobby, HobbyDTO>();
            CreateMap<HobbyDTO, Hobby>();
        }
    }
}
