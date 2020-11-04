using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Motivo_Finalizacion_Turno
{
    public class Motivo_Finalizacion_TurnoPagingModel
    {
        public List<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> Motivo_Finalizacion_Turnos { set; get; }
        public int RowCount { set; get; }
    }
}
