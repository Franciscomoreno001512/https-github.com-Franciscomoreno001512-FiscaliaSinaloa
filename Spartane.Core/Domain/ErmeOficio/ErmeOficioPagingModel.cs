using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.ErmeOficio
{
    public class ErmeOficioPagingModel
    {
        public List<Spartane.Core.Domain.ErmeOficio.ErmeOficio> ErmeOficios { set; get; }
        public int RowCount { set; get; }
    }
}
