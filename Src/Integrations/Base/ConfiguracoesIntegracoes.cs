using CalculoImposto.Integrations.CalculadoraConsumo.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Integrations.Base
{
    public static class ConfiguracoesIntegracoes
    {
        public static IServiceCollection ConfiguraIntegracoes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICalculadoraHttpClient,  CalculadoraHttpClient>();

            services.AddHttpClient<CalculadoraHttpClient>(client =>
            {
                string calculadoraConsumoApiUrl = configuration["Urls:CalculadoraConsumoApi"];
                if (string.IsNullOrEmpty(calculadoraConsumoApiUrl))
                {
                    throw new Exception("A URL da API de cálculo, não foi configurada.");
                }
                client.BaseAddress = new Uri(calculadoraConsumoApiUrl);
            });

            return services;
        }
    }
}
