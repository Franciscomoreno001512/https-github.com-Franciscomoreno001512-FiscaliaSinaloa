using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista
{
    public class Detalle_de_Asignacion_de_EspecialistaPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> Detalle_de_Asignacion_de_Especialistas { set; get; }
        public int RowCount { set; get; }
    }
}
