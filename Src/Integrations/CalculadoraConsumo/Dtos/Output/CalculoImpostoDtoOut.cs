using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrations.CalculadoraConsumo.Dtos.Output
{
    public class CalculoImpostoDtoOut
    {
        public List<Objeto> Objetos { get; set; }
        public Total Total { get; set; }
    }

    public class Objeto
    {
        public int NObj { get; set; }
        public TribCalc TribCalc { get; set; }
    }

    public class TribCalc
    {
        public IS IS { get; set; }
        public IBSCBS IBSCBS { get; set; }
    }

    public class IS
    {
        public int CSTIS { get; set; }
        public string CClassTribIS { get; set; }
        public decimal VBCIS { get; set; }
        public decimal PIS { get; set; }
        public decimal PISEspec { get; set; }
        public string UTrib { get; set; }
        public decimal QTrib { get; set; }
        public decimal VIS { get; set; }
        public string MemoriaCalculo { get; set; }
    }

    public class IBSCBS
    {
        public int CST { get; set; }
        public string CClassTrib { get; set; }
        public GIBSCBS GIBSCBS { get; set; }
        public GIBSCBSMono GIBSCBSMono { get; set; }
        public GTransfCred GTransfCred { get; set; }
        public GCredPresIBSZFM GCredPresIBSZFM { get; set; }
    }

    public class GIBSCBS
    {
        public decimal VBC { get; set; }
        public GIBSUF GIBSUF { get; set; }
        public GIBSMun GIBSMun { get; set; }
        public GCBS GCBS { get; set; }
        public GTribRegular GTribRegular { get; set; }
        public GIBSCredPres GIBSCredPres { get; set; }
        public GCBSCredPres GCBSCredPres { get; set; }
        public GTribCompraGov GTribCompraGov { get; set; }
    }

    public class GIBSUF
    {
        public decimal PIBSUF { get; set; }
        public GDif GDif { get; set; }
        public GDevTrib GDevTrib { get; set; }
        public GRed GRed { get; set; }
        public decimal VIBSUF { get; set; }
        public string MemoriaCalculo { get; set; }
    }

    public class GIBSMun
    {
        public decimal PIBSMun { get; set; }
        public GDif GDif { get; set; }
        public GDevTrib GDevTrib { get; set; }
        public GRed GRed { get; set; }
        public decimal VIBSMun { get; set; }
        public string MemoriaCalculo { get; set; }
    }

    public class GCBS
    {
        public decimal PCBS { get; set; }
        public GDif GDif { get; set; }
        public GDevTrib GDevTrib { get; set; }
        public GRed GRed { get; set; }
        public decimal VCBS { get; set; }
        public string MemoriaCalculo { get; set; }
    }

    public class GDif
    {
        public decimal PDif { get; set; }
        public decimal VDif { get; set; }
    }

    public class GDevTrib
    {
        public decimal VDevTrib { get; set; }
    }

    public class GRed
    {
        public decimal PRedAliq { get; set; }
        public decimal PAliqEfet { get; set; }
    }

    public class GTribRegular
    {
        public int CSTReg { get; set; }
        public string CClassTribReg { get; set; }
        public decimal PAliqEfetRegIBSUF { get; set; }
        public decimal VTribRegIBSUF { get; set; }
        public decimal PAliqEfetRegIBSMun { get; set; }
        public decimal VTribRegIBSMun { get; set; }
        public decimal PAliqEfetRegCBS { get; set; }
        public decimal VTribRegCBS { get; set; }
    }

    public class GIBSCredPres
    {
        public int CCredPres { get; set; }
        public decimal PCredPres { get; set; }
        public decimal VCredPres { get; set; }
        public decimal VCredPresCondSus { get; set; }
    }

    public class GCBSCredPres
    {
        public int CCredPres { get; set; }
        public decimal PCredPres { get; set; }
        public decimal VCredPres { get; set; }
        public decimal VCredPresCondSus { get; set; }
    }

    public class GTribCompraGov
    {
        public decimal PAliqIBSUF { get; set; }
        public decimal VTribIBSUF { get; set; }
        public decimal PAliqIBSMun { get; set; }
        public decimal VTribIBSMun { get; set; }
        public decimal PAliqCBS { get; set; }
        public decimal VTribCBS { get; set; }
    }

    public class GIBSCBSMono
    {
        public decimal QBCMono { get; set; }
        public decimal AdRemIBS { get; set; }
        public decimal AdRemCBS { get; set; }
        public decimal VIBSMono { get; set; }
        public decimal VCBSMono { get; set; }
        public decimal QBCMonoReten { get; set; }
        public decimal AdRemIBSReten { get; set; }
        public decimal VIBSMonoReten { get; set; }
        public decimal AdRemCBSReten { get; set; }
        public decimal VCBSMonoReten { get; set; }
        public decimal QBCMonoRet { get; set; }
        public decimal AdRemIBSRet { get; set; }
        public decimal VIBSMonoRet { get; set; }
        public decimal AdRemCBSRet { get; set; }
        public decimal VCBSMonoRet { get; set; }
        public decimal PDifIBS { get; set; }
        public decimal VIBSMonoDif { get; set; }
        public decimal PDifCBS { get; set; }
        public decimal VCBSMonoDif { get; set; }
        public decimal VTotIBSMonoItem { get; set; }
        public decimal VTotCBSMonoItem { get; set; }
    }

    public class GTransfCred
    {
        public decimal VIBS { get; set; }
        public decimal VCBS { get; set; }
    }

    public class GCredPresIBSZFM
    {
        public int TpCredPresIBSZFM { get; set; }
        public decimal VCredPresIBSZFM { get; set; }
    }

    public class Total
    {
        public TotalTribCalc TribCalc { get; set; }
    }

    public class TotalTribCalc
    {
        public ISTot ISTot { get; set; }
        public IBSCBSTot IBSCBSTot { get; set; }
    }

    public class ISTot
    {
        public decimal VIS { get; set; }
    }

    public class IBSCBSTot
    {
        public decimal VBCIBSCBS { get; set; }
        public GIBS GIBS { get; set; }
        public GCBS GCBS { get; set; }
        public GMono GMono { get; set; }
    }

    public class GIBS
    {
        public GIBSUF GIBSUF { get; set; }
        public GIBSMun GIBSMun { get; set; }
        public decimal VIBS { get; set; }
        public decimal VCredPres { get; set; }
        public decimal VCredPresCondSus { get; set; }
    }

    public class GMono
    {
        public decimal VIBSMono { get; set; }
        public decimal VCBSMono { get; set; }
        public decimal VIBSMonoReten { get; set; }
        public decimal VCBSMonoReten { get; set; }
        public decimal VIBSMonoRet { get; set; }
        public decimal VCBSMonoRet { get; set; }
    }

}
