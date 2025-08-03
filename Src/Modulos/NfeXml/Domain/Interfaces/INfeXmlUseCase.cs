using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfeXml.Domain.Interfaces
{
    public interface INfeXmlUseCase
    {
        Task<string> AtualizarXmlNfe(string nfeXml);
    }
}
