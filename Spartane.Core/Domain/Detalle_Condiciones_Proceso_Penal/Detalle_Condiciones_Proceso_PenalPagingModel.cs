using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal
{
    public class Detalle_Condiciones_Proceso_PenalPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal> Detalle_Condiciones_Proceso_Penals { set; get; }
        public int RowCount { set; get; }
    }
}
