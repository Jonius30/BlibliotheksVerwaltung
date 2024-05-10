namespace BibliotheksVerwaltungLib.Entities;

public class Kunde
{
    public int Id { get; private set; }
    public string? Titel { get; private set; }
    public string Vorname { get; private set; } = string.Empty;
    public string Nachname { get; private set; } = string.Empty;
    public string Strasse { get;private set; } = string.Empty;
    public int Hausnummer { get; private set; }
    public string? HausnummerZusatz { get; private set; }
    public string Postleitzahl { get; private set;} = string.Empty;
    public string Stadt { get; private set; } = string.Empty;
    public string? Telefonnummer { get; private set; }
    public string? Beruf { get; private set; }

    public Kunde()
    {

    }

    public Kunde(string? titel, string vorname, string nachname, string strasse, int hausnummer, string? hausnummerZusatz, string postleitzahl, string stadt, string? telefonnummer, string? beruf)
    {
        Titel = titel;
        Vorname = vorname;
        Nachname = nachname;
        Strasse = strasse;
        Hausnummer = hausnummer;
        HausnummerZusatz = hausnummerZusatz;
        Postleitzahl = postleitzahl;
        Stadt = stadt;
        Telefonnummer = telefonnummer;
        Beruf = beruf;
    }

    public void Update(string? titel, string vorname, string nachname, string strasse, int hausnummer, string? hausnummerZusatz, string postleitzahl, string stadt, string? telefonnummer, string? beruf)
    {
        Titel = titel;
        Vorname = vorname;
        Nachname = nachname;
        Strasse = strasse;
        Hausnummer = hausnummer;
        HausnummerZusatz = hausnummerZusatz;
        Postleitzahl = postleitzahl;
        Stadt = stadt;
        Telefonnummer = telefonnummer;
        Beruf = beruf;
    }
}
