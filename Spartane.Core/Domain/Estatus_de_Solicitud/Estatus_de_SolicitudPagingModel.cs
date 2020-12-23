using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_de_Solicitud
{
    public class Estatus_de_SolicitudPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_de_Solicitud.Estatus_de_Solicitud> Estatus_de_Solicituds { set; get; }
        public int RowCount { set; get; }
    }
}
