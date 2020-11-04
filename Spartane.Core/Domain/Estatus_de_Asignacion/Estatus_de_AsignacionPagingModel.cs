using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_de_Asignacion
{
    public class Estatus_de_AsignacionPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> Estatus_de_Asignacions { set; get; }
        public int RowCount { set; get; }
    }
}
