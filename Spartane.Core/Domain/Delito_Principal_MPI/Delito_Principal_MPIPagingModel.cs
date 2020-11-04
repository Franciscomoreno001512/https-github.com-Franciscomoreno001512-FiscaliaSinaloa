using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Delito_Principal_MPI
{
    public class Delito_Principal_MPIPagingModel
    {
        public List<Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI> Delito_Principal_MPIs { set; get; }
        public int RowCount { set; get; }
    }
}
