using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_Solicitud
{
    public class Estatus_SolicitudPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud> Estatus_Solicituds { set; get; }
        public int RowCount { set; get; }
    }
}
