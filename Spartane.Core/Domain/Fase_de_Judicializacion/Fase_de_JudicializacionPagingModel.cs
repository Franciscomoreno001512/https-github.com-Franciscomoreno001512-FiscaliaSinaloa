using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Fase_de_Judicializacion
{
    public class Fase_de_JudicializacionPagingModel
    {
        public List<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> Fase_de_Judicializacions { set; get; }
        public int RowCount { set; get; }
    }
}
