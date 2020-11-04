using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Causas_de_Interrupcion
{
    public class Causas_de_InterrupcionPagingModel
    {
        public List<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> Causas_de_Interrupcions { set; get; }
        public int RowCount { set; get; }
    }
}
