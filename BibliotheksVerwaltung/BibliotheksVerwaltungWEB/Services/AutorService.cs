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
            StringContent content = new(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage result = await _HttpClient.PostAsync(ApiRessource, content);
            AutorCreateResponse? response = JsonSerializer.Deserialize<AutorCreateResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Autor ?? new();
        }

        public async Task DeleteAsync(int autorId)
        {
            await _HttpClient.DeleteAsync(ApiRessource + $"/{autorId}");
        }

        public async Task<AutorDto> GetByIDAsync(AutorByIdRequest request)
        {
            HttpResponseMessage result = await _HttpClient.GetAsync(ApiRessource + $"/{request.AutorId}");
            AutorByIdResponse? response = JsonSerializer.Deserialize<AutorByIdResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Autor ?? new();
        }

        public async Task<List<AutorDto>> ListAsnyc()
        {
            HttpResponseMessage result = await _HttpClient.GetAsync(ApiRessource);
            AutorListResponse? response = JsonSerializer.Deserialize<AutorListResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Autoren ?? new();
        }

        public async Task<AutorDto> UpdateAsync(AutorUpdateRequest request)
        {
            StringContent content = new(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage result = await _HttpClient.PutAsJsonAsync(ApiRessource, content);
            AutorUpdateResponse? response = JsonSerializer.Deserialize<AutorUpdateResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Autor ?? new();
        }
    }
}
