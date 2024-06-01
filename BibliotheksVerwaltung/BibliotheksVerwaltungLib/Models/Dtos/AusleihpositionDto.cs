using BibliotheksVerwaltungLib.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Models.Dtos
{
    public class AusleihpositionDto
    {
        public Guid Id { get; private set; }
        public Bestand? Bestand { get; }
        public Ausleihe? Ausleihe { get; }
    }
}
