using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Documentos_Solicitantes
{
    public class Detalle_Documentos_SolicitantesPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> Detalle_Documentos_Solicitantess { set; get; }
        public int RowCount { set; get; }
    }
}
