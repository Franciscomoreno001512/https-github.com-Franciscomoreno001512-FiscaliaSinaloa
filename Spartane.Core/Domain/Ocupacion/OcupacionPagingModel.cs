using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Ocupacion
{
    public class OcupacionPagingModel
    {
        public List<Spartane.Core.Domain.Ocupacion.Ocupacion> Ocupacions { set; get; }
        public int RowCount { set; get; }
    }
}
