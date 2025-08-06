using Microsoft.AspNetCore.Http;
using NfeXml.Domain.Interfaces;
using NfeXml.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfeXml.Domain.Services
{
    public class NfeXmlUseCase : INfeXmlUseCase
    {
        private readonly IServices _services;
        public NfeXmlUseCase(IServices services) { _services = services; }

        public async Task<string> AtualizarXmlNfe(IFormFile xmlNfe)
        {
            NfeProc nfeProc = await _services.DesserializarXmlNfe(xmlNfe);

            return "teste";
        }
    }
}
