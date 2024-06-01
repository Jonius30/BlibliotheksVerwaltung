using BibliotheksVerwaltungLib.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Models.Dtos
{
    public class BestandDto
    {
        public Guid Id { get;  set; }
        public bool IsGekauft { get;  set; }
        public int Auflage { get;  set; }
        public Buch? Buch { get;  set; }
    }
}
