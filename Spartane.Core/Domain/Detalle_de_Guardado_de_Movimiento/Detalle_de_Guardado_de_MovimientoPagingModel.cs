using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Guardado_de_Movimiento
{
    public class Detalle_de_Guardado_de_MovimientoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Guardado_de_Movimiento.Detalle_de_Guardado_de_Movimiento> Detalle_de_Guardado_de_Movimientos { set; get; }
        public int RowCount { set; get; }
    }
}
