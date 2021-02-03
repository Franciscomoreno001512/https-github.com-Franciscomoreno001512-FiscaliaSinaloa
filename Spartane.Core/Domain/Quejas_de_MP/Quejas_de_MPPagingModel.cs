using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Quejas_de_MP
{
    public class Quejas_de_MPPagingModel
    {
        public List<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP> Quejas_de_MPs { set; get; }
        public int RowCount { set; get; }
    }
}
