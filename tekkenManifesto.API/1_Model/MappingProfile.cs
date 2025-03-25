using AutoMapper;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.DTO;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Character, CharInDTO>().ReverseMap();
        CreateMap<Character, CharOutDTO>().ReverseMap();
    }
}