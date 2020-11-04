using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Requerido_Acuerdo
{
    public class Detalle_Requerido_AcuerdoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo> Detalle_Requerido_Acuerdos { set; get; }
        public int RowCount { set; get; }
    }
}
