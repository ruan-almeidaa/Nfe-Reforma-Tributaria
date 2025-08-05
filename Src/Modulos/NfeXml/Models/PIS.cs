using System.Xml.Serialization;

namespace NfeXml.Models
{
    public class PIS
    {
        [XmlElement("PISAliq")]
        public PISAliq PISAliq { get; set; }
    }

    public class PISAliq
    {
        public string CST { get; set; }
        public decimal vPIS { get; set; }
    }
}
