using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.expediente_ministerio_publico
{
    public class expediente_ministerio_publicoPagingModel
    {
        public List<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> expediente_ministerio_publicos { set; get; }
        public int RowCount { set; get; }
    }
}
