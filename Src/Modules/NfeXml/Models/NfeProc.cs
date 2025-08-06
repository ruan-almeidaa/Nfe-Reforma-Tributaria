using System.Xml.Serialization;

namespace NfeXml.Models
{
    [XmlRoot("nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class NfeProc
    {
        [XmlElement("NFe")]
        public NFe NFe { get; set; }

        [XmlAttribute("versao")]
        public string Versao { get; set; }

        [XmlAttribute("xmlns")]
        public string Xmlns { get; set; }
    }

 


}