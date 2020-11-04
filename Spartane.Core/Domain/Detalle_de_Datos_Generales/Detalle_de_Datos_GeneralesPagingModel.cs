using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Datos_Generales
{
    public class Detalle_de_Datos_GeneralesPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales> Detalle_de_Datos_Generaless { set; get; }
        public int RowCount { set; get; }
    }
}
