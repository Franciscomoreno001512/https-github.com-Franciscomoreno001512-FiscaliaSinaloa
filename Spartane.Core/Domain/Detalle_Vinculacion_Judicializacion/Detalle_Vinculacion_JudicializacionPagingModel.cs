using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion
{
    public class Detalle_Vinculacion_JudicializacionPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion> Detalle_Vinculacion_Judicializacions { set; get; }
        public int RowCount { set; get; }
    }
}
