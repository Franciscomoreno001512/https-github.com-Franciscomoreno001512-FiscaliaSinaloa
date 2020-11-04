using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Agravantes
{
    public class AgravantesPagingModel
    {
        public List<Spartane.Core.Domain.Agravantes.Agravantes> Agravantess { set; get; }
        public int RowCount { set; get; }
    }
}
