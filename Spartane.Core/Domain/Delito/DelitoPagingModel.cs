using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Delito
{
    public class DelitoPagingModel
    {
        public List<Spartane.Core.Domain.Delito.Delito> Delitos { set; get; }
        public int RowCount { set; get; }
    }
}
