using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Orden
{
    public class Tipo_de_OrdenPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Orden.Tipo_de_Orden> Tipo_de_Ordens { set; get; }
        public int RowCount { set; get; }
    }
}
