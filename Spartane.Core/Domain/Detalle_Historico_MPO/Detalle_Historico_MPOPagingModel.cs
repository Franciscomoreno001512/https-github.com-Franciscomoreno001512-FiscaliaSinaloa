using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Historico_MPO
{
    public class Detalle_Historico_MPOPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Historico_MPO.Detalle_Historico_MPO> Detalle_Historico_MPOs { set; get; }
        public int RowCount { set; get; }
    }
}
