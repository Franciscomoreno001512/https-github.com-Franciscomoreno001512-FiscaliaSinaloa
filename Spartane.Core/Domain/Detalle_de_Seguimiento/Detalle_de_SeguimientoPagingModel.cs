using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Seguimiento
{
    public class Detalle_de_SeguimientoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Seguimiento.Detalle_de_Seguimiento> Detalle_de_Seguimientos { set; get; }
        public int RowCount { set; get; }
    }
}
