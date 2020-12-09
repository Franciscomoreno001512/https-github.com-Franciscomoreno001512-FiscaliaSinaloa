using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Notificaciones
{
    public class NotificacionesPagingModel
    {
        public List<Spartane.Core.Domain.Notificaciones.Notificaciones> Notificacioness { set; get; }
        public int RowCount { set; get; }
    }
}
