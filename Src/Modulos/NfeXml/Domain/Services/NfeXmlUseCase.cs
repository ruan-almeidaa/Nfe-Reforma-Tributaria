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
        public async Task<string> AtualizarXmlNfe(string nfeXml)
        {
            NfeProc nfeProc = _services.DesserializarXmlNfe(nfeXml);
            return "teste";
        }
    }
}
