namespace BibliotheksVerwaltungLib.Entities;

public class Autor
{
    public int Id { get; private set; }
    public string? Titel { get; private set; }
    public string Vorname { get; private set; } = string.Empty;
    public string Nachname { get; private set; } = string.Empty;

    public Autor()
    {
            
    }

    public Autor(string? titel, string vorname, string nachname)
    {
        Titel= titel;
        Vorname = vorname;
        Nachname = nachname;
    }

    public void Update(string? titel, string vorname, string nachname)
    {
        Titel = titel;
        Vorname = vorname;
        Nachname = nachname;
    }
}
