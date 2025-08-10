using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrations.CalculadoraConsumo.Dtos.Input
{
    public class CalculoImpostoDtoIn
    {
        public string Id { get; set; }
        public string Versao { get; set; }
        public DateTime DataHoraEmissao { get; set; }
        public int Municipio { get; set; }
        public string Uf { get; set; }
        public List<Item> Itens { get; set; }
    }

    public class Item
    {
        public int Numero { get; set; }
        public string Ncm { get; set; }
        public string Nbs { get; set; }
        public string Cst { get; set; }
        public decimal BaseCalculo { get; set; }
        public decimal Quantidade { get; set; }
        public string Unidade { get; set; }
        public ImpostoSeletivo ImpostoSeletivo { get; set; }
        public TributacaoRegular TributacaoRegular { get; set; }
        public string CClassTrib { get; set; }
    }

    public class ImpostoSeletivo
    {
        public string Cst { get; set; }
        public decimal BaseCalculo { get; set; }
        public decimal Quantidade { get; set; }
        public string Unidade { get; set; }
        public decimal ImpostoInformado { get; set; }
        public string CClassTrib { get; set; }
    }

    public class TributacaoRegular
    {
        public string Cst { get; set; }
        public string CClassTrib { get; set; }
    }

}
