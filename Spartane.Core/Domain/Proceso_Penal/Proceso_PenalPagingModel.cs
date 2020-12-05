using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Proceso_Penal
{
    public class Proceso_PenalPagingModel
    {
        public List<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal> Proceso_Penals { set; get; }
        public int RowCount { set; get; }
    }
}
