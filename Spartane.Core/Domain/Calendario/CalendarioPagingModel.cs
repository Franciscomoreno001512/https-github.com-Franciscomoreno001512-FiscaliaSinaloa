using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Calendario
{
    public class CalendarioPagingModel
    {
        public List<Spartane.Core.Domain.Calendario.Calendario> Calendarios { set; get; }
        public int RowCount { set; get; }
    }
}
