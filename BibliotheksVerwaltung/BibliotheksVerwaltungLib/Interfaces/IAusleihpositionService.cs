using BibliotheksVerwaltungLib.Models.Dtos;
using BibliotheksVerwaltungLib.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Interfaces
{
    public interface IAusleihpositionService
    {
        public Task<List<AusleihpositionDto>> ListAsnyc();
        public Task<AusleihpositionDto> GetByIDAsync(AusleihpositionByIdRequest request);

        public Task<AusleihpositionDto> CreateAsync(AusleihpositionCreateRequest request);
        public Task<AusleihpositionDto> UpdateAsync(AusleihpositionUpdateRequest request);
        public Task DeleteAsync(int ausleihpositionId);
    }
}
