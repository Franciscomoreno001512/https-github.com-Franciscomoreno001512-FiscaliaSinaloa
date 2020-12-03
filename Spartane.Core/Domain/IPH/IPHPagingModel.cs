using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.IPH
{
    public class IPHPagingModel
    {
        public List<Spartane.Core.Domain.IPH.IPH> IPHs { set; get; }
        public int RowCount { set; get; }
    }
}
