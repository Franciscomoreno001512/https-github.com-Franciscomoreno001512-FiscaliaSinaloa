using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.PasaTurnos
{
    public class PasaTurnosPagingModel
    {
        public List<Spartane.Core.Domain.PasaTurnos.PasaTurnos> PasaTurnoss { set; get; }
        public int RowCount { set; get; }
    }
}
