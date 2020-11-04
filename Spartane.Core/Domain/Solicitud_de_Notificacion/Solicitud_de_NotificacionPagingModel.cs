using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Solicitud_de_Notificacion
{
    public class Solicitud_de_NotificacionPagingModel
    {
        public List<Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion> Solicitud_de_Notificacions { set; get; }
        public int RowCount { set; get; }
    }
}
