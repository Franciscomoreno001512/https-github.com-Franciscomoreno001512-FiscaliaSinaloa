using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Resolucion
{
    public class ResolucionPagingModel
    {
        public List<Spartane.Core.Domain.Resolucion.Resolucion> Resolucions { set; get; }
        public int RowCount { set; get; }
    }
}
