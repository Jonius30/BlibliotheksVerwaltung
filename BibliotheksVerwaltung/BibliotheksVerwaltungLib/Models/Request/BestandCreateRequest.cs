using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Models.Request
{
    public class BestandCreateRequest
    {
        public string? Gekauft { get; set; } = string.Empty;
        public int Auflage { get; set; } 
        public string FK_BuchISBN { get; set; } = string.Empty;
    }
}
