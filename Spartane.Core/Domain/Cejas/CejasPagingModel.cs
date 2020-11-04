using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Cejas
{
    public class CejasPagingModel
    {
        public List<Spartane.Core.Domain.Cejas.Cejas> Cejass { set; get; }
        public int RowCount { set; get; }
    }
}
