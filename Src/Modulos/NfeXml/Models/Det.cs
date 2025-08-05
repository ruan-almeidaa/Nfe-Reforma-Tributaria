using System.Xml.Serialization;

namespace NfeXml.Models
{
    public class Det
    {
        [XmlAttribute("nItem")]
        public int nItem { get; set; }

        [XmlElement("prod")]
        public Prod Prod { get; set; }

        [XmlElement("imposto")]
        public Imposto Imposto { get; set; }
    }
}
