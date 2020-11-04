using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Documento
{
    public class Tipo_de_DocumentoPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento> Tipo_de_Documentos { set; get; }
        public int RowCount { set; get; }
    }
}
