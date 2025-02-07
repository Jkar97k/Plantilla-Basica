using api_basica.Dtos;
using api_basica.Repository.Models;
using AutoMapper;

namespace api_basica.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Paciente,PacienteDTO>().ReverseMap();
            CreateMap<Paciente,PacientePostDTO>().ReverseMap();
            CreateMap<Pais,PaisDTO>().ReverseMap();
        }
    }
}
