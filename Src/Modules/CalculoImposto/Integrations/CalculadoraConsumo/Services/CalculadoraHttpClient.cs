using Microsoft.AspNetCore.Http;

namespace CalculoImposto.Integrations.CalculadoraConsumo.Services
{
    internal class CalculadoraHttpClient : ICalculadoraHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
    }
}
