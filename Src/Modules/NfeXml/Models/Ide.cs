using System.Xml.Serialization;

namespace NfeXml.Models
{
    public class Ide
    {
        [XmlElement("dhEmi")]
        public DateTime dhEmi { get; set; }
    }
}
