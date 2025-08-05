using System.Xml.Serialization;

namespace NfeXml.Models
{
    public class COFINS
    {
        [XmlElement("COFINSAliq")]
        public COFINSAliq COFINSAliq { get; set; }
    }

    public class COFINSAliq
    {
        public string CST { get; set; }
        public decimal vCOFINS { get; set; }
    }
}
