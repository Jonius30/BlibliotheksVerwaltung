using BibliotheksVerwaltungLib.Entities;

namespace BibliotheksVerwaltungLib.Aggregates;

public class Ausleihe
{
    public Guid Id { get; private set; }
    public DateTime Ausleihdatum { get; private set; }
    public DateTime Enddatum { get; private set; }
    public int? KundeId { get; private set; }
    public Kunde? Kunde { get; private set; }

    public Ausleihe()
    {
        Id = Guid.NewGuid();
    }

    public Ausleihe(DateTime ausleihdatum, DateTime enddatum, int? kundeId)
    {
        Id = Guid.NewGuid();
        Ausleihdatum = ausleihdatum;
        Enddatum = enddatum;
        KundeId = kundeId;
    }

    public void Update(DateTime ausleihdatum, DateTime enddatum, int? kundeId)
    {
        Ausleihdatum = ausleihdatum;
        Enddatum = enddatum;
        KundeId = kundeId;
    }

    public void SetKunde(Kunde kunde)
    {
        Kunde = kunde;
        KundeId = kunde.Id;
    }
}
