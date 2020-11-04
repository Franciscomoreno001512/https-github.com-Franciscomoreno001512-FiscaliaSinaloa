using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Resultado_de_Notificacion
{
    public class Resultado_de_NotificacionPagingModel
    {
        public List<Spartane.Core.Domain.Resultado_de_Notificacion.Resultado_de_Notificacion> Resultado_de_Notificacions { set; get; }
        public int RowCount { set; get; }
    }
}
