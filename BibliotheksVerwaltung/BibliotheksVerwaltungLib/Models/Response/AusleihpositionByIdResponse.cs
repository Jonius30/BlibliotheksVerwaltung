using BibliotheksVerwaltungLib.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Models.Response
{
    public class AusleihpositionByIdResponse
    {
        public AusleihpositionDto Ausleihposition { get; set; } = new();
    }
}
