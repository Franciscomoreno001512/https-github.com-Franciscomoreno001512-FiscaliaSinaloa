using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Audiencias_MP
{
    public class Audiencias_MPPagingModel
    {
        public List<Spartane.Core.Domain.Audiencias_MP.Audiencias_MP> Audiencias_MPs { set; get; }
        public int RowCount { set; get; }
    }
}
