using BibliotheksVerwaltungLib.Models.Dtos;
using BibliotheksVerwaltungLib.Models.Request;
using BibliotheksVerwaltungLib.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungLib.Interfaces
{
    public interface IAutorService
    {
        public Task<List<AutorDto>> ListAsnyc();
        public Task<AutorDto> GetByIDAsync(AutorByIdRequest request);

        public Task<AutorDto> CreateAsync(AutorCreateRequest request);
        public Task<AutorDto> UpdateAsync(AutorUpdateRequest request);
        public Task DeleteAsync(int autorId);
    }
}
