using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Requerido_MPI
{
    public class Requerido_MPIPagingModel
    {
        public List<Spartane.Core.Domain.Requerido_MPI.Requerido_MPI> Requerido_MPIs { set; get; }
        public int RowCount { set; get; }
    }
}
