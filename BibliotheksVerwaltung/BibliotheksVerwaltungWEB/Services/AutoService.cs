using BibliotheksVerwaltungLib.Interfaces;
using BibliotheksVerwaltungLib.Models.Dtos;
using BibliotheksVerwaltungLib.Models.Request;
using BibliotheksVerwaltungLib.Models.Response;
using System.Net.Http.Json;
using System.Text.Json;

namespace BibliotheksVerwaltungWEB.Services
{
    public class AutorService : IAutorService
    {
        private readonly HttpClient _HttpClient;
        private const string ApiRessource = "autor";
        public AutorService(HttpClient httpClient) 
        { 
            _HttpClient = httpClient;
        }
        public async Task<AutorDto> CreateAsync(AutorCreateRequest request)
        {
            StringContent content = new(JsonSerializer.Serialize(request));
            HttpResponseMessage result = await _HttpClient.PostAsync(ApiRessource, content);
            AutorDto? autor = JsonSerializer.Deserialize<AutorDto>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return autor ?? new();
        }

        public async Task DeleteAsync(int autorId)
        {
            throw new NotImplementedException();
        }

        public async Task<AutorDto> GetByIDAsync(AutorByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AutorDto>> ListAsnyc()
        {
            throw new NotImplementedException();
        }

        public async Task<AutorDto> UpdateAsync(AutorUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
