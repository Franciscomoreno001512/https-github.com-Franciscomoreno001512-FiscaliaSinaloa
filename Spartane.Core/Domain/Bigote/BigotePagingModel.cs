using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Bigote
{
    public class BigotePagingModel
    {
        public List<Spartane.Core.Domain.Bigote.Bigote> Bigotes { set; get; }
        public int RowCount { set; get; }
    }
}
