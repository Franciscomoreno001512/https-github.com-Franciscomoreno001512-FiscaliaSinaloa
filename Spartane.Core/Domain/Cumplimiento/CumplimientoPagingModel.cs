using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Cumplimiento
{
    public class CumplimientoPagingModel
    {
        public List<Spartane.Core.Domain.Cumplimiento.Cumplimiento> Cumplimientos { set; get; }
        public int RowCount { set; get; }
    }
}
