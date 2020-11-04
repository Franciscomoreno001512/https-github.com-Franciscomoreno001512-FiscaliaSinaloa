using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Agravantes_del_Delito
{
    public class Agravantes_del_DelitoPagingModel
    {
        public List<Spartane.Core.Domain.Agravantes_del_Delito.Agravantes_del_Delito> Agravantes_del_Delitos { set; get; }
        public int RowCount { set; get; }
    }
}
