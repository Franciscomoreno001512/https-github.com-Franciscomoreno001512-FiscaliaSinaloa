using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Identificacion
{
    public class IdentificacionPagingModel
    {
        public List<Spartane.Core.Domain.Identificacion.Identificacion> Identificacions { set; get; }
        public int RowCount { set; get; }
    }
}
