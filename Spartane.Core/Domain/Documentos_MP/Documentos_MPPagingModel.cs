using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Documentos_MP
{
    public class Documentos_MPPagingModel
    {
        public List<Spartane.Core.Domain.Documentos_MP.Documentos_MP> Documentos_MPs { set; get; }
        public int RowCount { set; get; }
    }
}
