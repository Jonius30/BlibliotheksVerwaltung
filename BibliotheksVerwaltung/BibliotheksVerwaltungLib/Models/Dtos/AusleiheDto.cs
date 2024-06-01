using BibliotheksVerwaltungLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Models.Dtos
{
    public class AusleiheDto
    {
        public Guid Id { get; private set; }
        public DateTime Ausleihdatum { get; set; }
        public DateTime Enddatum { get; set; }
        public Kunde? Kunde { get; set; }
    }
}
