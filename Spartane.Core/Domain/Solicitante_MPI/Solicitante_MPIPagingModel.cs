using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Solicitante_MPI
{
    public class Solicitante_MPIPagingModel
    {
        public List<Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI> Solicitante_MPIs { set; get; }
        public int RowCount { set; get; }
    }
}
