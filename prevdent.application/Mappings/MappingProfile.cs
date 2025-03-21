using AutoMapper;
using prevdent.application.Dtos;
using prevdent.domain.Entities;
using PrevDent.Appllication.Dtos;
using PrevDent.Domain.Entities;

namespace prevdent.application.Mappings;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<PacienteEntity, PacienteDTO>().ReverseMap();
        CreateMap<DentistaEntity, DentistaDTO>().ReverseMap();
    }
}
