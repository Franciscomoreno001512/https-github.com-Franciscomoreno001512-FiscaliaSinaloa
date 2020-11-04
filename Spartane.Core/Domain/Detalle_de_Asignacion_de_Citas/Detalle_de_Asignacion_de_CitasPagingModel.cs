using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Asignacion_de_Citas
{
    public class Detalle_de_Asignacion_de_CitasPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Asignacion_de_Citas.Detalle_de_Asignacion_de_Citas> Detalle_de_Asignacion_de_Citass { set; get; }
        public int RowCount { set; get; }
    }
}
