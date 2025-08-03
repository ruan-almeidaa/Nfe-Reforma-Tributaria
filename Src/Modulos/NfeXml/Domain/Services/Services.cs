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
        public NfeProc DesserializarXmlNfe(string conteudoXml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(NfeProc));
            using var reader = new StringReader(conteudoXml);
            return (NfeProc)serializer.Deserialize(reader);
        }
    }
}
