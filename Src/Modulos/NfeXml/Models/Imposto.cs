using System.Xml.Serialization;

namespace NfeXml.Models
{
    public class Imposto
    {
        [XmlElement("ICMS")]
        public ICMS ICMS { get; set; }

        [XmlElement("PIS")]
        public PIS PIS { get; set; }

        [XmlElement("COFINS")]
        public COFINS COFINS { get; set; }
    }
}
