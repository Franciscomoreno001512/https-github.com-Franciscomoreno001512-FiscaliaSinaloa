using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Desestimacion
{
    public class Detalle_de_DesestimacionPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Desestimacion.Detalle_de_Desestimacion> Detalle_de_Desestimacions { set; get; }
        public int RowCount { set; get; }
    }
}
