using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Referencia
{
    public class Detalle_de_ReferenciaPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Referencia.Detalle_de_Referencia> Detalle_de_Referencias { set; get; }
        public int RowCount { set; get; }
    }
}
