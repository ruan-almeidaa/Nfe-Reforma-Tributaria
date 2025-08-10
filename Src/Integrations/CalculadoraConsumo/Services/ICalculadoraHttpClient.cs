using Integrations.CalculadoraConsumo.Dtos.Input;
using Integrations.CalculadoraConsumo.Dtos.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Integrations.CalculadoraConsumo.Services
{
    public interface ICalculadoraHttpClient
    {
        public Task<List<CstDto>> BuscarListaCsts(DateTime dataVigencia);
        public Task<CalculoImpostoDtoOut> CalcularImpostos(CalculoImpostoDtoIn calculoImpostoDtoIn);
        public Task<decimal> CalcularBaseCbsIbsItem(BaseCalculoCibsDtoIn baseCalculoCibsDtoIn);
        public Task<decimal> CalcularBaseIsItem(BaseCalculoIsDtoIn baseCalculoIsDtoIn);

    }
}
