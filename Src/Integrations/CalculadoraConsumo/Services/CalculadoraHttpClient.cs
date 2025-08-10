using Integrations.CalculadoraConsumo.Dtos.Input;
using Integrations.CalculadoraConsumo.Dtos.Output;
using System.Text;
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

        public Task<decimal> CalcularBaseCbsIbsItem(BaseCalculoCibsDtoIn baseCalculoCibsDtoIn)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> CalcularBaseIsItem(BaseCalculoIsDtoIn baseCalculoIsDtoIn)
        {
            throw new NotImplementedException();
        }

        public async Task<CalculoImpostoDtoOut> CalcularImpostos(CalculoImpostoDtoIn calculoImpostoDtoIn)
        {
            string endpointApi = $"regime-geral";
            string conteudoRequisicao = JsonSerializer.Serialize(calculoImpostoDtoIn);
            var corpoRequisicao = new StringContent(conteudoRequisicao, Encoding.UTF8, "application/json");

            var resposta = await _httpClient.PostAsync(endpointApi, corpoRequisicao);
            resposta.EnsureSuccessStatusCode();

            var jsonString = await resposta.Content.ReadAsStringAsync();
            CalculoImpostoDtoOut calculoImpostoDtoOut = JsonSerializer.Deserialize<CalculoImpostoDtoOut>(jsonString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return calculoImpostoDtoOut;
        }
    }
}
