using BibliotheksVerwaltungLib.Models.Dtos;
using BibliotheksVerwaltungLib.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Interfaces
{
    public interface IBestandService
    {
        public Task<List<BestandDto>> ListAsnyc();
        public Task<BestandDto> GetByIDAsync(BestandByIdRequest request);

        public Task<BestandDto> CreateAsync(BestandCreateRequest request);
        public Task<BestandDto> UpdateAsync(BestandUpdateRequest request);
        public Task DeleteAsync(int bestandId);
    }
}
