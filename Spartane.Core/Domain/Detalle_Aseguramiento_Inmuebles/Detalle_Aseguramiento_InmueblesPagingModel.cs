using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles
{
    public class Detalle_Aseguramiento_InmueblesPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles> Detalle_Aseguramiento_Inmuebless { set; get; }
        public int RowCount { set; get; }
    }
}
