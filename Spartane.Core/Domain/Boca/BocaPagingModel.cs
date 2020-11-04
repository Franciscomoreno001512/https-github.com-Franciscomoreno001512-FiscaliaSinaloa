using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Boca
{
    public class BocaPagingModel
    {
        public List<Spartane.Core.Domain.Boca.Boca> Bocas { set; get; }
        public int RowCount { set; get; }
    }
}
