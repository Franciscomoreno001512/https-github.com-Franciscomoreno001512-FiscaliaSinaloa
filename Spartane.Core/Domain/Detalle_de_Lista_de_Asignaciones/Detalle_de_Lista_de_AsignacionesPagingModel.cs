using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Lista_de_Asignaciones
{
    public class Detalle_de_Lista_de_AsignacionesPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Lista_de_Asignaciones.Detalle_de_Lista_de_Asignaciones> Detalle_de_Lista_de_Asignacioness { set; get; }
        public int RowCount { set; get; }
    }
}
