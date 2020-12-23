using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Registro_de_Mandamiento_Judicial
{
    public class Registro_de_Mandamiento_JudicialPagingModel
    {
        public List<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial> Registro_de_Mandamiento_Judicials { set; get; }
        public int RowCount { set; get; }
    }
}
