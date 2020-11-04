using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial
{
    public class Detalle_de_Mensaje_de_HistorialPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_Historial> Detalle_de_Mensaje_de_Historials { set; get; }
        public int RowCount { set; get; }
    }
}
