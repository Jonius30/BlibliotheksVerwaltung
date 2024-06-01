using BibliotheksVerwaltungLib.Models.Dtos;
using BibliotheksVerwaltungLib.Models.Request;
using BibliotheksVerwaltungLib.Models.Response;
using System.Net.Http.Json;
using System.Text.Json;

namespace BibliotheksVerwaltungWEB.Services
{
    public class BestandService
    {
        private readonly HttpClient _HttpClient;
        private const string ApiRessource = "bestand";
        public BestandService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }
        public async Task<BestandDto> CreateAsync(BestandCreateRequest request)
        {
            StringContent content = new(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage result = await _HttpClient.PostAsync(ApiRessource, content);
            BestandCreateResponse? response = JsonSerializer.Deserialize<BestandCreateResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Bestand ?? new();
        }

        public async Task DeleteAsync(int bestandId)
        {
            await _HttpClient.DeleteAsync(ApiRessource + $"/{bestandId}");
        }

        public async Task<BestandDto> GetByIDAsync(BestandByIdRequest request)
        {
            HttpResponseMessage result = await _HttpClient.GetAsync(ApiRessource + $"/{request.BestandId}");
            BestandByIdResponse? response = JsonSerializer.Deserialize<BestandByIdResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Bestand ?? new();
        }

        public async Task<List<BestandDto>> ListAsnyc()
        {
            HttpResponseMessage result = await _HttpClient.GetAsync(ApiRessource);
            BestandListResponse? response = JsonSerializer.Deserialize<BestandListResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Bestaende ?? new();
        }

        public async Task<BestandDto> UpdateAsync(BestandUpdateRequest request)
        {
            StringContent content = new(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage result = await _HttpClient.PutAsJsonAsync(ApiRessource, content);
            BestandUpdateResponse? response = JsonSerializer.Deserialize<BestandUpdateResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Bestand ?? new();
        }
    }
}
