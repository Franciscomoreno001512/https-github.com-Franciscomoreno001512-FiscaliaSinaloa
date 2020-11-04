using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Imputado
{
    public class Detalle_de_ImputadoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado> Detalle_de_Imputados { set; get; }
        public int RowCount { set; get; }
    }
}
