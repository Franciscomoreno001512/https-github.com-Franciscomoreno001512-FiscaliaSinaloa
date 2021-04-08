using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial
{
    public class Resolucion_de_Mandamiento_JudicialPagingModel
    {
        public List<Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial> Resolucion_de_Mandamiento_Judicials { set; get; }
        public int RowCount { set; get; }
    }
}
