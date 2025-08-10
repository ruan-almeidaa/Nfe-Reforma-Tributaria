using CalculoImposto.Domain.Interfaces;
using CalculoImposto.Dtos.Input;
using Helpers;
using Integrations.CalculadoraConsumo.Dtos.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Domain.Services
{
    internal class CalculoImpostoUseCase : ICalculoImpostoUseCase
    {
        public Task<PadraoRespostasApi<CalculoImpostoDtoOut>> CalcularImpostosReformaTriburia(CalculoImpostoRequestDto calculoImpostoRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
