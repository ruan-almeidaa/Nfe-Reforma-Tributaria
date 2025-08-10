using Integrations.CalculadoraConsumo.Dtos.Output;
using System.Text.Json;

namespace CalculoImposto.Integrations.CalculadoraConsumo.Services
{
    internal class CalculadoraHttpClient : ICalculadoraHttpClient
    {
        private readonly HttpClient _httpClient;

        public async Task<List<CstDto>> BuscarListaCsts(DateTime dataVigencia)
        {
            string endpointApi = $"dados-abertos/situacoes-tributarias/cbs-ibs?data={dataVigencia:yyyy-MM-dd}";
            var resposta = await _httpClient.GetAsync(endpointApi);
            resposta.EnsureSuccessStatusCode();
            var jsonString = await resposta.Content.ReadAsStringAsync();
            List<CstDto> listaCsts = JsonSerializer.Deserialize<List<CstDto>>(jsonString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return listaCsts ?? new List<CstDto>();
        }
    }
}
