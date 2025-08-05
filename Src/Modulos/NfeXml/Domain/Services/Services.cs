using Microsoft.AspNetCore.Http;
using NfeXml.Domain.Interfaces;
using NfeXml.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NfeXml.Domain.Services
{
    internal class Services : IServices
    {

        public async Task<NfeProc> DesserializarXmlNfe(IFormFile xmlNfe)
        {
            using StreamReader reader = new StreamReader(xmlNfe.OpenReadStream());
            var conteudoXml = await reader.ReadToEndAsync();

            XmlSerializer serializer = new XmlSerializer(typeof(NfeProc));
            using StringReader stringReader = new StringReader(conteudoXml);
            return (NfeProc)serializer.Deserialize(stringReader);
        }
    }
}
