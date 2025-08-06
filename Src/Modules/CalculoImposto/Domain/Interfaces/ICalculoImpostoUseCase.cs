using CalculoImposto.Dtos.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Domain.Interfaces
{
    public interface ICalculoImpostoUseCase
    {
        Task<string> CalcularImpostosReformaTriburia(CalculoImpostoRequestDto calculoImpostoRequestDto);
    }
}
