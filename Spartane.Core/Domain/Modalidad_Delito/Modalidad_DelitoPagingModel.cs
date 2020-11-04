using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Modalidad_Delito
{
    public class Modalidad_DelitoPagingModel
    {
        public List<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> Modalidad_Delitos { set; get; }
        public int RowCount { set; get; }
    }
}
