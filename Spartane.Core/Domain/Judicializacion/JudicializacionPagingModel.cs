using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Judicializacion
{
    public class JudicializacionPagingModel
    {
        public List<Spartane.Core.Domain.Judicializacion.Judicializacion> Judicializacions { set; get; }
        public int RowCount { set; get; }
    }
}
