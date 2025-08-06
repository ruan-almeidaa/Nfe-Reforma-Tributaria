using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Dtos.Input
{
    public class ItemDto
    {
        public required int Numero { get; set; }
        public required string Ncm { get; set; }
        public required string Nbs { get; set; }
        public required decimal Quantidade { get; set; }
        public required string UnidadeMedida { get; set; }
        public required string OrigemMerc { get; set; }
        public required string IcmsCST { get; set; }
        public required decimal ValorFornecimento { get; set; }
        public required decimal AjusteValorOperacao { get; set; }
        public required decimal Juros { get; set; }
        public required decimal Multas { get; set; }
        public required decimal Acrescimos { get; set; }
        public required decimal Encargos { get; set; }
        public required decimal DescontosCondicionais { get; set; }
        public required decimal FretePorDentro { get; set; }
        public required decimal OutrosTributos { get; set; }
        public required decimal DemaisImportancias { get; set; }
        public required decimal ImpostoInformado { get; set; }
        public required decimal ValorIntegralCobrado { get; set; }
        public required decimal Bonificacao { get; set; }
        public required decimal DevolucaoVendas { get; set; }
        public required decimal ValorIcms { get; set; }
        public required decimal ValorIss { get; set; }
        public required decimal ValorPis { get; set; }
        public required decimal ValorCofins { get; set; }

    }

}
