using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Delito_Mandamiento_Judicial
{
    public class Detalle_de_Delito_Mandamiento_JudicialPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Delito_Mandamiento_Judicial.Detalle_de_Delito_Mandamiento_Judicial> Detalle_de_Delito_Mandamiento_Judicials { set; get; }
        public int RowCount { set; get; }
    }
}
