using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal
{
    public class Detalle_Delitos_Proceso_PenalPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_Penal> Detalle_Delitos_Proceso_Penals { set; get; }
        public int RowCount { set; get; }
    }
}
