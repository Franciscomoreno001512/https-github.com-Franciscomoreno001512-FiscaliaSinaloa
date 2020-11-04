using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento
{
    public class Detalle_de_Solicitante_ProcedimientoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_Procedimiento> Detalle_de_Solicitante_Procedimientos { set; get; }
        public int RowCount { set; get; }
    }
}
