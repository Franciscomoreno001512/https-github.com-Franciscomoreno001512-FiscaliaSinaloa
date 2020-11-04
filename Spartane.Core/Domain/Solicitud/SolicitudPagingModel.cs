using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Solicitud
{
    public class SolicitudPagingModel
    {
        public List<Spartane.Core.Domain.Solicitud.Solicitud> Solicituds { set; get; }
        public int RowCount { set; get; }
    }
}
