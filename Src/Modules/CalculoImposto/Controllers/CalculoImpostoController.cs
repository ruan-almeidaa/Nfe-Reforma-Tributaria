using CalculoImposto.Dtos.Input;
using Helpers;
using Integrations.CalculadoraConsumo.Dtos.Output;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculoImpostoController : ControllerBase
    {
        [HttpPost("calcularImpostosReformaTributaria")]
        public async Task<ActionResult<PadraoRespostasApi<CalculoImpostoDtoOut>>> CalcularImpostosReformaTributaria([FromBody] CalculoImpostoRequestDto calculoImpostoRequestDto)
        {

        }
    }
}
