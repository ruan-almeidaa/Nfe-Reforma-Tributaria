using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NfeXml.Models
{
    public class IPI
    {
        [XmlElement("cEnq")]
        public string CEnq { get; set; } // Código de Enquadramento Legal do IPI

        [XmlElement("IPITrib", typeof(IPITrib))]
        [XmlElement("IPINT", typeof(IPINT))]
        public object Item { get; set; }
    }

    public class IPITrib
    {
        [XmlElement("CST")]
        public string CST { get; set; }

        [XmlElement("vBC")]
        public decimal? VBC { get; set; }

        [XmlElement("pIPI")]
        public decimal? PIPI { get; set; }

        [XmlElement("qUnid")]
        public decimal? QUnid { get; set; }

        [XmlElement("vUnid")]
        public decimal? VUnid { get; set; }

        [XmlElement("vIPI")]
        public decimal VIPI { get; set; }
    }

    public class IPINT
    {
        [XmlElement("CST")]
        public string CST { get; set; }
    }

}
