using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Especificacion_Detencion
{
    public class Especificacion_DetencionPagingModel
    {
        public List<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> Especificacion_Detencions { set; get; }
        public int RowCount { set; get; }
    }
}
