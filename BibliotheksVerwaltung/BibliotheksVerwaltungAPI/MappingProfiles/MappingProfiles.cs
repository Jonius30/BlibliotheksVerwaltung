using AutoMapper;
using BibliotheksVerwaltungLib.Aggregates;
using BibliotheksVerwaltungLib.Entities;
using BibliotheksVerwaltungLib.Models.Dtos;

namespace BibliotheksVerwaltungAPI.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Autor, AutorDto>();
            CreateMap<Ausleihe, AusleiheDto>();
            CreateMap<Ausleihposition, AusleihpositionDto>();
            CreateMap<Bestand, BestandDto>();
            CreateMap<Buch, BuchDto>();
            CreateMap<Kunde, KundeDto>();
            CreateMap<Verlag, VerlagDto>();
        }
    }
}
