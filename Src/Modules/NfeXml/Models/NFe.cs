using System.Xml.Serialization;

namespace NfeXml.Models
{
    public class NFe
    {
        [XmlElement("infNFe")]
        public InfNFe InfNFe { get; set; }
    }
}
