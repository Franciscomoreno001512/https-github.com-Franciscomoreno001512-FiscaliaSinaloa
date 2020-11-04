using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_documentos
{
    public class Detalle_de_documentosPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos> Detalle_de_documentoss { set; get; }
        public int RowCount { set; get; }
    }
}
