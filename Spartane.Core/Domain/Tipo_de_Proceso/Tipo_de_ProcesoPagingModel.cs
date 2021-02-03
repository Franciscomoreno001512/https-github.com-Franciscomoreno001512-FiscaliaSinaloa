using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Proceso
{
    public class Tipo_de_ProcesoPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Proceso.Tipo_de_Proceso> Tipo_de_Procesos { set; get; }
        public int RowCount { set; get; }
    }
}
