namespace BibliotheksVerwaltungLib.Aggregates;

public class Bestand
{
    public Guid Id { get; private set; }
    public bool IsGekauft { get; private set; }
    public int Auflage { get; private set; }
    public string? BuchISBN { get; private set; }
    public Buch? Buch { get; private set; }

    public Bestand()
    {
        Id = Guid.NewGuid();
    }

    public Bestand(int auflage, bool isGekauft, string? buchId)
    {
        Id = Guid.NewGuid();
        Auflage = auflage;
        IsGekauft= isGekauft;
        BuchISBN = buchId;
    }

    public void Update(Guid id, bool isGekauft, string? buchId)
    {
        Id = id;
        IsGekauft = isGekauft;
        BuchISBN = buchId;
    }

    public void SetBuch(Buch buch)
    {
        Buch = buch;
        BuchISBN = buch.ISBN;
    }
}
