using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Historial_de_Conversacion
{
    public class Historial_de_ConversacionPagingModel
    {
        public List<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> Historial_de_Conversacions { set; get; }
        public int RowCount { set; get; }
    }
}
