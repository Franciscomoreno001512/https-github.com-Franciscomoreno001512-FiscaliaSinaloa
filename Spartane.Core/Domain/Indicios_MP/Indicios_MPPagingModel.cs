using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Indicios_MP
{
    public class Indicios_MPPagingModel
    {
        public List<Spartane.Core.Domain.Indicios_MP.Indicios_MP> Indicios_MPs { set; get; }
        public int RowCount { set; get; }
    }
}
