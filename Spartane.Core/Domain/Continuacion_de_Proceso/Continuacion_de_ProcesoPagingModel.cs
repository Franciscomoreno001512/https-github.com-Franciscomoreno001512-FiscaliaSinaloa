using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Continuacion_de_Proceso
{
    public class Continuacion_de_ProcesoPagingModel
    {
        public List<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso> Continuacion_de_Procesos { set; get; }
        public int RowCount { set; get; }
    }
}
