using BibliotheksVerwaltungLib.Models.Dtos;

namespace BibliotheksVerwaltungLib.Models.Response;

public class AutorListResponse
{
    public List<AutorDto> Autoren { get; set; } = new List<AutorDto>();
}
