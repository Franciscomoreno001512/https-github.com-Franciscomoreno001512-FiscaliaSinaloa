using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante
{
    public class Detalle_de_Solicitud_SolicitantePagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante> Detalle_de_Solicitud_Solicitantes { set; get; }
        public int RowCount { set; get; }
    }
}
