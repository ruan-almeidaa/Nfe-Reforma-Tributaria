using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NfeXml.Domain.Interfaces;
using NfeXml.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfeXml.Infra
{
    public static class ConfiguracoesModulo
    {
        public static IServiceCollection AddModuloNfeXml(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<INfeXmlUseCase, NfeXmlUseCase>();
            services.AddScoped<IServices, Services>();

            return services;
        }

    }
}
