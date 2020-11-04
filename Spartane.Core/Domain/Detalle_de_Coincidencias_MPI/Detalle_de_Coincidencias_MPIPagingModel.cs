using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Coincidencias_MPI
{
    public class Detalle_de_Coincidencias_MPIPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Coincidencias_MPI.Detalle_de_Coincidencias_MPI> Detalle_de_Coincidencias_MPIs { set; get; }
        public int RowCount { set; get; }
    }
}
