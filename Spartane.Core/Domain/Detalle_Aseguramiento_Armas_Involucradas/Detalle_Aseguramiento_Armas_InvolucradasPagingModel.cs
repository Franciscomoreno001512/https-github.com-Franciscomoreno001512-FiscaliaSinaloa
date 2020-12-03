using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas
{
    public class Detalle_Aseguramiento_Armas_InvolucradasPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_Involucradas> Detalle_Aseguramiento_Armas_Involucradass { set; get; }
        public int RowCount { set; get; }
    }
}
