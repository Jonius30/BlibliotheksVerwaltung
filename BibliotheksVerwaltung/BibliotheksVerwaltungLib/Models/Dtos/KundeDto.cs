using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Models.Dtos
{
    public class KundeDto
    {
        public int Id { get;  set; }
        public string? Titel { get;  set; }
        public string Vorname { get;  set; } = string.Empty;
        public string Nachname { get;  set; } = string.Empty;
        public string Strasse { get;  set; } = string.Empty;
        public int Hausnummer { get;  set; }
        public string? HausnummerZusatz { get;  set; }
        public string Postleitzahl { get;  set; } = string.Empty;
        public string Stadt { get;  set; } = string.Empty;
        public string? Telefonnummer { get;  set; }
        public string? Beruf { get;  set; }
    }
}
