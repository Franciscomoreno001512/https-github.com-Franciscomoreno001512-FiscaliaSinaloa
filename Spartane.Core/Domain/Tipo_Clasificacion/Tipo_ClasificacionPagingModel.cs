using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_Clasificacion
{
    public class Tipo_ClasificacionPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> Tipo_Clasificacions { set; get; }
        public int RowCount { set; get; }
    }
}
