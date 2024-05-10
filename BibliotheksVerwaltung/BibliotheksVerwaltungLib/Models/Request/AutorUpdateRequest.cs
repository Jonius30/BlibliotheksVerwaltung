using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Models.Request
{
    public class AutorUpdateRequest : AutorCreateRequest
    {
        public int AutorId { get; set; }
    }
}
