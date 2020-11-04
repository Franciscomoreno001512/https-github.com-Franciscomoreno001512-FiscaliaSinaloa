using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Delito_de_Justicia
{
    public class Detalle_de_Delito_de_JusticiaPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia> Detalle_de_Delito_de_Justicias { set; get; }
        public int RowCount { set; get; }
    }
}
