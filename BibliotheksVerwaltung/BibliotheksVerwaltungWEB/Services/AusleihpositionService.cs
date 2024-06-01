using BibliotheksVerwaltungLib.Models.Dtos;
using BibliotheksVerwaltungLib.Models.Request;
using BibliotheksVerwaltungLib.Models.Response;
using System.Net.Http.Json;
using System.Text.Json;

namespace BibliotheksVerwaltungWEB.Services
{
    public class AusleihpositionService
    {
        private readonly HttpClient _HttpClient;
        private const string ApiRessource = "ausleihposition";
        public AusleihpositionService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }
        public async Task<AusleihpositionDto> CreateAsync(AusleihpositionCreateRequest request)
        {
            StringContent content = new(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage result = await _HttpClient.PostAsync(ApiRessource, content);
            AusleihpositionCreateResponse? response = JsonSerializer.Deserialize<AusleihpositionCreateResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Ausleihposition ?? new();
        }

        public async Task DeleteAsync(int ausleihpositionId)
        {
            await _HttpClient.DeleteAsync(ApiRessource + $"/{ausleihpositionId}");
        }

        public async Task<AusleihpositionDto> GetByIDAsync(AusleihpositionByIdRequest request)
        {
            HttpResponseMessage result = await _HttpClient.GetAsync(ApiRessource + $"/{request.AusleihpositionId}");
            AusleihpositionByIdResponse? response = JsonSerializer.Deserialize<AusleihpositionByIdResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Ausleihposition ?? new();
        }

        public async Task<List<AusleihpositionDto>> ListAsnyc()
        {
            HttpResponseMessage result = await _HttpClient.GetAsync(ApiRessource);
            AusleihpositionListResponse? response = JsonSerializer.Deserialize<AusleihpositionListResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Ausleihpositionen ?? new();
        }

        public async Task<AusleihpositionDto> UpdateAsync(AusleihpositionUpdateRequest request)
        {
            StringContent content = new(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage result = await _HttpClient.PutAsJsonAsync(ApiRessource, content);
            AusleihpositionUpdateResponse? response = JsonSerializer.Deserialize<AusleihpositionUpdateResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response?.Ausleihposition ?? new();
        }
    }
}
