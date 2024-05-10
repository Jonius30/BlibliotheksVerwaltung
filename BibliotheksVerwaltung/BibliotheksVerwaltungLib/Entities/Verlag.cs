namespace BibliotheksVerwaltungLib.Entities;

public class Verlag
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;

    public Verlag()
    {

    }

    public Verlag(string name)
    {
        Name = name;
    }

    public void Update(string name)
    {
        Name = name;
    }
}
