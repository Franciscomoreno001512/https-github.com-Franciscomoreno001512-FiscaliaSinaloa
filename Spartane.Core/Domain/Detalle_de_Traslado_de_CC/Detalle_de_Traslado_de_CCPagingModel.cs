using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Traslado_de_CC
{
    public class Detalle_de_Traslado_de_CCPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Traslado_de_CC.Detalle_de_Traslado_de_CC> Detalle_de_Traslado_de_CCs { set; get; }
        public int RowCount { set; get; }
    }
}
