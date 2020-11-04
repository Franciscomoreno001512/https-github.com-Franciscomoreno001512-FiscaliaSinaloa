using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Delito
{
    public class Detalle_de_DelitoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito> Detalle_de_Delitos { set; get; }
        public int RowCount { set; get; }
    }
}
