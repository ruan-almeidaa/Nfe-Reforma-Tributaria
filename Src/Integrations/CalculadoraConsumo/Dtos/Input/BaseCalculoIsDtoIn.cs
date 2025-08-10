using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrations.CalculadoraConsumo.Dtos.Input
{
    public class BaseCalculoIsDtoIn
    {
        public decimal ValorIntegralCobrado { get; set; }
        public decimal AjusteValorOperacao { get; set; }
        public decimal Juros { get; set; }
        public decimal Multas { get; set; }
        public decimal Acrescimos { get; set; }
        public decimal Encargos { get; set; }
        public decimal DescontosCondicionais { get; set; }
        public decimal FretePorDentro { get; set; }
        public decimal OutrosTributos { get; set; }
        public decimal DemaisImportancias { get; set; }
        public decimal Icms { get; set; }
        public decimal Iss { get; set; }
        public decimal Pis { get; set; }
        public decimal Cofins { get; set; }
        public decimal Bonificacao { get; set; }
        public decimal DevolucaoVendas { get; set; }
    }
}
