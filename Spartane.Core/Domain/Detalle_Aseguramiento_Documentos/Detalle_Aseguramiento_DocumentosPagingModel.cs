using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Documentos
{
    public class Detalle_Aseguramiento_DocumentosPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Aseguramiento_Documentos.Detalle_Aseguramiento_Documentos> Detalle_Aseguramiento_Documentoss { set; get; }
        public int RowCount { set; get; }
    }
}
