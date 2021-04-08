using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Fuente_de_Mandamiento_Judicial
{
    public class Fuente_de_Mandamiento_JudicialPagingModel
    {
        public List<Spartane.Core.Domain.Fuente_de_Mandamiento_Judicial.Fuente_de_Mandamiento_Judicial> Fuente_de_Mandamiento_Judicials { set; get; }
        public int RowCount { set; get; }
    }
}
