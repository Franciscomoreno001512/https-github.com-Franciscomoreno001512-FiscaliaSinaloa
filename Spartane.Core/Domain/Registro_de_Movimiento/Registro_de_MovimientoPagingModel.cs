using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Registro_de_Movimiento
{
    public class Registro_de_MovimientoPagingModel
    {
        public List<Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento> Registro_de_Movimientos { set; get; }
        public int RowCount { set; get; }
    }
}
