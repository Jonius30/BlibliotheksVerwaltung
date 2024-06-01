using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Models.Request
{
    public class AusleihpositionCreateRequest
    {
        public string? FK_BestandId { get; set; }
        public string FK_AusleihId { get; set; } = string.Empty;
    }
}
