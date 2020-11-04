using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Turnos
{
    public class TurnosPagingModel
    {
        public List<Spartane.Core.Domain.Turnos.Turnos> Turnoss { set; get; }
        public int RowCount { set; get; }
    }
}
