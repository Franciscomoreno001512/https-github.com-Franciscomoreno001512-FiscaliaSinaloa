using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Personas_a_Incluir
{
    public class Detalle_de_Personas_a_IncluirPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir> Detalle_de_Personas_a_Incluirs { set; get; }
        public int RowCount { set; get; }
    }
}
