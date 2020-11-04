using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Asignacion_de_Turnos
{
    public class Asignacion_de_TurnosPagingModel
    {
        public List<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos> Asignacion_de_Turnoss { set; get; }
        public int RowCount { set; get; }
    }
}
