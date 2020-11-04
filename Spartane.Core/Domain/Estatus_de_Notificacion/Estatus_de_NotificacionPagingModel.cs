using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_de_Notificacion
{
    public class Estatus_de_NotificacionPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_de_Notificacion.Estatus_de_Notificacion> Estatus_de_Notificacions { set; get; }
        public int RowCount { set; get; }
    }
}
