using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Judicializacion
{
    public class Tipo_de_JudicializacionPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Judicializacion.Tipo_de_Judicializacion> Tipo_de_Judicializacions { set; get; }
        public int RowCount { set; get; }
    }
}
