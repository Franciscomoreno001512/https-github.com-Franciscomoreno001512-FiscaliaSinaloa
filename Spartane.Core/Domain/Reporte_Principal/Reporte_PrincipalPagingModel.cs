using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Reporte_Principal
{
    public class Reporte_PrincipalPagingModel
    {
        public List<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> Reporte_Principals { set; get; }
        public int RowCount { set; get; }
    }
}
