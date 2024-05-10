using BibliotheksVerwaltungLib.Models.Dtos;

namespace BibliotheksVerwaltungLib.Models.Response;

public class AutorByIdResponse
{
    public AutorDto Autor { get; set; } = new();
}
