using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Dtos.Input
{
    public class CalculoImpostoRequestDto
    {
        public required DateTime DataHoraEmissao { get; set; }
        public required int Municipio { get; set; }
        public required string Uf { get; set; }
        public required List<ItemDto> Itens { get; set; }
    }

}
