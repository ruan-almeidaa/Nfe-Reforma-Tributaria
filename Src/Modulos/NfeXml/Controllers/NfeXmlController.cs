using Microsoft.AspNetCore.Mvc;
using NfeXml.Domain.Interfaces;
using NfeXml.Dtos.Input;
using NfeXml.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfeXml.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NfeXmlController : ControllerBase
    {
        private readonly INfeXmlUseCase _nfeXmlUseCase;
        public NfeXmlController(INfeXmlUseCase nfeXmlUseCase)
        {
            _nfeXmlUseCase = nfeXmlUseCase;
        }

        [HttpPost("Atualizar-xml")]
        public async Task<ActionResult<string>> AtualizarXml([FromBody] NfeXmlAtualizarXmlDto xmlAtualizarXmlDto)
        {
            return await _nfeXmlUseCase.AtualizarXmlNfe(xmlAtualizarXmlDto.ConteudoXmlNfe);
        }
    }
}
