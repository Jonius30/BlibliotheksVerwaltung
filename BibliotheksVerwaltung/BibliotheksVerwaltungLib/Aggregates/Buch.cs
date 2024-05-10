using BibliotheksVerwaltungLib.Entities;

namespace BibliotheksVerwaltungLib.Aggregates;

public class Buch
{
    public string ISBN { get; private set; } = string.Empty;
    public string Title { get; private set; } = string.Empty;
    public int Jahr { get; private set; }
    public int? AuthorId { get; private set; }
    public int? VerlagId { get; private set; }
    public Autor? Autor { get; private set; }
    public Verlag? Verlag { get; private set; }

    public Buch()
    {

    }
   
    public Buch(string isbn, string title, int jahr, int? authorId, int? verlagId)
    {
        ISBN = isbn;
        Title = title;
        Jahr = jahr;
        AuthorId = authorId;
        VerlagId = verlagId;
    }
    public void Update(string isbn, string title, int jahr, int? authorId, int? verlagId)
    {
        ISBN = isbn;
        Title = title;
        Jahr = jahr;
        AuthorId = authorId;
        VerlagId = verlagId;
    }

    public void SetAutor(Autor autor)
    {
        Autor = autor;
        AuthorId = autor.Id;
    }

    public void SetVerlag(Verlag verlag)
    {
        Verlag = verlag;
        VerlagId = Verlag.Id;   
    }
}
