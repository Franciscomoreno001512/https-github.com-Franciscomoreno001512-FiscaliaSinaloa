using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_Delito
{
    public class Tipo_DelitoPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_Delito.Tipo_Delito> Tipo_Delitos { set; get; }
        public int RowCount { set; get; }
    }
}
