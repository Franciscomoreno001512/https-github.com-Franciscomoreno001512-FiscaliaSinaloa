using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Lugares
{
    public class LugaresPagingModel
    {
        public List<Spartane.Core.Domain.Lugares.Lugares> Lugaress { set; get; }
        public int RowCount { set; get; }
    }
}
