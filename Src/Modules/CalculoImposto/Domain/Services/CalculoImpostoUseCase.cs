using CalculoImposto.Domain.Interfaces;
using CalculoImposto.Dtos.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Domain.Services
{
    internal class CalculoImpostoUseCase : ICalculoImpostoUseCase
    {
        public Task<string> CalcularImpostosReformaTriburia(CalculoImpostoRequestDto calculoImpostoRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
