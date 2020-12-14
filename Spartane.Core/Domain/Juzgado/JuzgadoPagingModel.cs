using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Juzgado
{
    public class JuzgadoPagingModel
    {
        public List<Spartane.Core.Domain.Juzgado.Juzgado> Juzgados { set; get; }
        public int RowCount { set; get; }
    }
}
