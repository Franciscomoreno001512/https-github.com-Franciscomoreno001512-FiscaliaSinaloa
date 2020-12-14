using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Resolucion
{
    public class Tipo_de_ResolucionPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Resolucion.Tipo_de_Resolucion> Tipo_de_Resolucions { set; get; }
        public int RowCount { set; get; }
    }
}
