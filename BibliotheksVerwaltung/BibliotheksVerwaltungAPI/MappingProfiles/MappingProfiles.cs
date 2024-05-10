using AutoMapper;
using BibliotheksVerwaltungLib.Entities;
using BibliotheksVerwaltungLib.Models.Dtos;

namespace BibliotheksVerwaltungAPI.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Autor, AutorDto>();
        }
    }
}
