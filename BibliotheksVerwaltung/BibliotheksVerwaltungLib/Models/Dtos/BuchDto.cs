using BibliotheksVerwaltungLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Models.Dtos
{
    public class BuchDto
    {
        public string ISBN { get;  set; } = string.Empty;
        public string Title { get;  set; } = string.Empty;
        public int Jahr { get;  set; }
        public Autor? Autor { get;  set; }
        public Verlag? Verlag { get;  set; }
    }
}
