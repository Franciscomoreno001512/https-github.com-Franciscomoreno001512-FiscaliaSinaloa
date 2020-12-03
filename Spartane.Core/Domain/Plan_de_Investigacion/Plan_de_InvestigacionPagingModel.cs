using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Plan_de_Investigacion
{
    public class Plan_de_InvestigacionPagingModel
    {
        public List<Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion> Plan_de_Investigacions { set; get; }
        public int RowCount { set; get; }
    }
}
