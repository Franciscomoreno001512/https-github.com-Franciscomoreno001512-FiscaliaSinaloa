using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Retroalimentacion
{
    public class Detalle_de_RetroalimentacionPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Retroalimentacion.Detalle_de_Retroalimentacion> Detalle_de_Retroalimentacions { set; get; }
        public int RowCount { set; get; }
    }
}
