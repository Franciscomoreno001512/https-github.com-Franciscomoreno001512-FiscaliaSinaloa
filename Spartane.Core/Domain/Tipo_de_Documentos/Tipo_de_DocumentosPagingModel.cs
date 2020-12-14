using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Documentos
{
    public class Tipo_de_DocumentosPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Documentos.Tipo_de_Documentos> Tipo_de_Documentoss { set; get; }
        public int RowCount { set; get; }
    }
}
