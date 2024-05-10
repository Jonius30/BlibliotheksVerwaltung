namespace BibliotheksVerwaltungLib.Models.Dtos;

public class AutorDto
{
    public int Id { get; set; }
    public string? Titel { get; set; }
    public string Vorname { get; set; } = string.Empty;
    public string Nachname { get; set; } = string.Empty;
}
