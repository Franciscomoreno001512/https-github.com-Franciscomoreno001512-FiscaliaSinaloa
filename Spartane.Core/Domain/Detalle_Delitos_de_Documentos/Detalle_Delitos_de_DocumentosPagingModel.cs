using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Delitos_de_Documentos
{
    public class Detalle_Delitos_de_DocumentosPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Delitos_de_Documentos.Detalle_Delitos_de_Documentos> Detalle_Delitos_de_Documentoss { set; get; }
        public int RowCount { set; get; }
    }
}
