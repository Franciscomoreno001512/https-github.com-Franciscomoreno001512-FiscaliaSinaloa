using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Solicitud_Seguimiento
{
    public class Detalle_de_Solicitud_SeguimientoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Solicitud_Seguimiento.Detalle_de_Solicitud_Seguimiento> Detalle_de_Solicitud_Seguimientos { set; get; }
        public int RowCount { set; get; }
    }
}
