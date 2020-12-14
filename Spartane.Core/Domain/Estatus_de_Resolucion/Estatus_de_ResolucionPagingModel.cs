using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_de_Resolucion
{
    public class Estatus_de_ResolucionPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion> Estatus_de_Resolucions { set; get; }
        public int RowCount { set; get; }
    }
}
