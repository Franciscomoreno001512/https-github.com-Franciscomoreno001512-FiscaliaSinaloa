using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Forma_Accion_Delito
{
    public class Forma_Accion_DelitoPagingModel
    {
        public List<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> Forma_Accion_Delitos { set; get; }
        public int RowCount { set; get; }
    }
}
