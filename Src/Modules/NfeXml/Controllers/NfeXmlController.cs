using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NfeXml.Domain.Interfaces;

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
        public async Task<ActionResult<string>> AtualizarXml([FromForm] IFormFile xmlNfe)
        {
            return await _nfeXmlUseCase.AtualizarXmlNfe(xmlNfe);
        }
    }
}
