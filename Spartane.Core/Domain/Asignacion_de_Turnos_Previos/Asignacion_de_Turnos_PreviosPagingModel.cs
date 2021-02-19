using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Asignacion_de_Turnos_Previos
{
    public class Asignacion_de_Turnos_PreviosPagingModel
    {
        public List<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> Asignacion_de_Turnos_Previoss { set; get; }
        public int RowCount { set; get; }
    }
}
