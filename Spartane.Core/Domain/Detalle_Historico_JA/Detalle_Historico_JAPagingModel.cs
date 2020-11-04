using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Historico_JA
{
    public class Detalle_Historico_JAPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA> Detalle_Historico_JAs { set; get; }
        public int RowCount { set; get; }
    }
}
