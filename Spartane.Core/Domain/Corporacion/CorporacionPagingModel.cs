using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Corporacion
{
    public class CorporacionPagingModel
    {
        public List<Spartane.Core.Domain.Corporacion.Corporacion> Corporacions { set; get; }
        public int RowCount { set; get; }
    }
}
