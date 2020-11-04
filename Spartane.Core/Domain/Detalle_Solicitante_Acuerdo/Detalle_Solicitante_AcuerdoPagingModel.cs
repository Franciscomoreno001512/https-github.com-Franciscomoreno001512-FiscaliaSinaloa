using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Solicitante_Acuerdo
{
    public class Detalle_Solicitante_AcuerdoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo> Detalle_Solicitante_Acuerdos { set; get; }
        public int RowCount { set; get; }
    }
}
