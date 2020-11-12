using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Forma_de_Cumplimiento
{
    public class Forma_de_CumplimientoPagingModel
    {
        public List<Spartane.Core.Domain.Forma_de_Cumplimiento.Forma_de_Cumplimiento> Forma_de_Cumplimientos { set; get; }
        public int RowCount { set; get; }
    }
}
