using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Solicitud
{
    public class Tipo_de_SolicitudPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud> Tipo_de_Solicituds { set; get; }
        public int RowCount { set; get; }
    }
}
