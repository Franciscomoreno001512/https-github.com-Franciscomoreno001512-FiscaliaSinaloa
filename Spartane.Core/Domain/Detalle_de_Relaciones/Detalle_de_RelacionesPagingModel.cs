using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Relaciones
{
    public class Detalle_de_RelacionesPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones> Detalle_de_Relacioness { set; get; }
        public int RowCount { set; get; }
    }
}
