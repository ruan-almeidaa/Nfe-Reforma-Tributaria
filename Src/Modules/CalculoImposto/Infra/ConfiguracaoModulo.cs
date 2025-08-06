using CalculoImposto.Domain.Interfaces;
using CalculoImposto.Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Infra
{
    public static class ConfiguracaoModulo
    {
        public static IServiceCollection AddModuloCalculoImposto(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICalculoImpostoUseCase, CalculoImpostoUseCase>();
            services.AddScoped<IServices, Services>();

            return services;
        }
    }
}
