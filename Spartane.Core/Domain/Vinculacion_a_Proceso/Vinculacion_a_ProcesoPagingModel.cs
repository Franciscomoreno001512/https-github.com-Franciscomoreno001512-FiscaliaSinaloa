using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Vinculacion_a_Proceso
{
    public class Vinculacion_a_ProcesoPagingModel
    {
        public List<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> Vinculacion_a_Procesos { set; get; }
        public int RowCount { set; get; }
    }
}
