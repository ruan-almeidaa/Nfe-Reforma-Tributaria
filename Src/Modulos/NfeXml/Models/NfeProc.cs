using System;
using System.Collections.Generic;
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

    public class NFe
    {
        [XmlElement("infNFe")]
        public InfNFe InfNFe { get; set; }
    }

    public class InfNFe
    {
        [XmlElement("ide")]
        public Ide Ide { get; set; }

        [XmlElement("det")]
        public List<Det> Det { get; set; }

        [XmlAttribute("versao")]
        public string Versao { get; set; }
    }

    public class Ide
    {
        [XmlElement("dhEmi")]
        public DateTime dhEmi { get; set; }
    }

    public class Det
    {
        [XmlAttribute("nItem")]
        public int nItem { get; set; }

        [XmlElement("prod")]
        public Prod Prod { get; set; }

        [XmlElement("imposto")]
        public Imposto Imposto { get; set; }
    }

    public class Prod
    {
        public string NCM { get; set; }
        public string uCom { get; set; }
        public decimal qCom { get; set; }
    }

    public class Imposto
    {
        [XmlElement("ICMS")]
        public ICMS ICMS { get; set; }

        [XmlElement("PIS")]
        public PIS PIS { get; set; }

        [XmlElement("COFINS")]
        public COFINS COFINS { get; set; }
    }

    public class ICMS
    {
        [XmlElement("ICMS00", typeof(ICMS00))]
        [XmlElement("ICMS10", typeof(ICMS10))]
        [XmlElement("ICMS20", typeof(ICMS20))]
        [XmlElement("ICMS30", typeof(ICMS30))]
        [XmlElement("ICMS40", typeof(ICMS40))]
        [XmlElement("ICMS51", typeof(ICMS51))]
        [XmlElement("ICMS60", typeof(ICMS60))]
        [XmlElement("ICMS70", typeof(ICMS70))]
        [XmlElement("ICMS90", typeof(ICMS90))]
        public object Item { get; set; }
    }


    // Todas as classes ICMS conforme layout da NF-e modelo 55
    public class ICMS00
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public decimal vBC { get; set; }
        public decimal pICMS { get; set; }
        public decimal vICMS { get; set; }
    }

    public class ICMS10
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public decimal vBC { get; set; }
        public decimal pICMS { get; set; }
        public decimal vICMS { get; set; }
        public string modBCST { get; set; }
        public decimal pMVAST { get; set; }
        public decimal pRedBCST { get; set; }
        public decimal vBCST { get; set; }
        public decimal pICMSST { get; set; }
        public decimal vICMSST { get; set; }
    }

    public class ICMS20
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public decimal pRedBC { get; set; }
        public decimal vBC { get; set; }
        public decimal pICMS { get; set; }
        public decimal vICMS { get; set; }
    }

    public class ICMS30
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public decimal pMVAST { get; set; }
        public decimal pRedBCST { get; set; }
        public decimal vBCST { get; set; }
        public decimal pICMSST { get; set; }
        public decimal vICMSST { get; set; }
        public decimal vICMSDeson { get; set; }
        public string motDesICMS { get; set; }
    }

    public class ICMS40
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string motDesICMS { get; set; }
    }

    public class ICMS51
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public decimal pRedBC { get; set; }
        public decimal vBC { get; set; }
        public decimal pICMS { get; set; }
        public decimal vICMSOp { get; set; }
        public decimal pDif { get; set; }
        public decimal vICMSDif { get; set; }
        public decimal vICMS { get; set; }
    }

    public class ICMS60
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public decimal vBCSTRet { get; set; }
        public decimal vICMSSTRet { get; set; }
        public string pST { get; set; }
    }

    public class ICMS70
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public decimal pRedBC { get; set; }
        public decimal vBC { get; set; }
        public decimal pICMS { get; set; }
        public decimal vICMS { get; set; }
        public string modBCST { get; set; }
        public decimal pMVAST { get; set; }
        public decimal pRedBCST { get; set; }
        public decimal vBCST { get; set; }
        public decimal pICMSST { get; set; }
        public decimal vICMSST { get; set; }
        public decimal vICMSDeson { get; set; }
        public string motDesICMS { get; set; }
    }

    public class ICMS90
    {
        public string orig { get; set; }
        public string CST { get; set; }
        public string modBC { get; set; }
        public decimal vBC { get; set; }
        public decimal pRedBC { get; set; }
        public decimal pICMS { get; set; }
        public decimal vICMS { get; set; }
        public string modBCST { get; set; }
        public decimal pMVAST { get; set; }
        public decimal pRedBCST { get; set; }
        public decimal vBCST { get; set; }
        public decimal pICMSST { get; set; }
        public decimal vICMSST { get; set; }
        public decimal vICMSDeson { get; set; }
        public string motDesICMS { get; set; }
    }



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