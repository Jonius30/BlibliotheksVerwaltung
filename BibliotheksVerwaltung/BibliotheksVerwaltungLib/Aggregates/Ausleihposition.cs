namespace BibliotheksVerwaltungLib.Aggregates;

public class Ausleihposition
{
    public Guid Id { get; private set; }
    public Guid? BestandId { get; private set; }
    public Guid? AusleihId { get; private set; }
    public Bestand? Bestand { get; private set; }
    public Ausleihe? Ausleihe { get; private set; }

    public Ausleihposition()
    {
        Id = Guid.NewGuid();
    }

    public void SetAusleihe(Ausleihe ausleihe)
    {
        Ausleihe = ausleihe;
        AusleihId = ausleihe.Id;
    }

    public void SetBestand(Bestand bestand)
    {
        Bestand = bestand;
        BestandId = bestand.Id;
    }
}
