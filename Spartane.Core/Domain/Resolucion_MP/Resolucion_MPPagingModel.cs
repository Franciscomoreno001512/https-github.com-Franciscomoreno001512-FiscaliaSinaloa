using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Resolucion_MP
{
    public class Resolucion_MPPagingModel
    {
        public List<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP> Resolucion_MPs { set; get; }
        public int RowCount { set; get; }
    }
}
