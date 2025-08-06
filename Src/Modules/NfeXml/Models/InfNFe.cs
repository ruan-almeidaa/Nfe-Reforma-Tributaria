using System.Xml.Serialization;

namespace NfeXml.Models
{
    public class InfNFe
    {
        [XmlElement("ide")]
        public Ide Ide { get; set; }

        [XmlElement("det")]
        public List<Det> Det { get; set; }

        [XmlAttribute("versao")]
        public string Versao { get; set; }
    }
}
