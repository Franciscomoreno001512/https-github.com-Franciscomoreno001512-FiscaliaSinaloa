using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Amparo
{
    public class Detalle_de_AmparoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Amparo.Detalle_de_Amparo> Detalle_de_Amparos { set; get; }
        public int RowCount { set; get; }
    }
}
