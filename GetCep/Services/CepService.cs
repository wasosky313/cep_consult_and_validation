using System.Text.Json;
using GetCep.Models;

namespace GetCep.Services
{
    public class GetCepService
    {
        private readonly HttpClient _httpClient;

        public GetCepService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<CepResponse?> GetCepAsync(string number) // TODO maybe use number as int.
        {
            var url = $"https://viacep.com.br/ws/{number}/json/";  // TODO create object to construct this inside like CepExternalApi
            var response = await _httpClient.GetAsync(url);        // TODO to make request and handle response

            if (!response.IsSuccessStatusCode) return null; // TODO how can raise 404 here?
            var content = await response.Content.ReadAsStringAsync();
            var cepResponse = JsonSerializer.Deserialize<CepResponse>(content);
            return cepResponse;
        }
    }
}

