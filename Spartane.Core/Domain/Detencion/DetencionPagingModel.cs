using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detencion
{
    public class DetencionPagingModel
    {
        public List<Spartane.Core.Domain.Detencion.Detencion> Detencions { set; get; }
        public int RowCount { set; get; }
    }
}
