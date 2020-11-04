using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Documentos_MPI
{
    public class Detalle_de_Documentos_MPIPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Documentos_MPI.Detalle_de_Documentos_MPI> Detalle_de_Documentos_MPIs { set; get; }
        public int RowCount { set; get; }
    }
}
