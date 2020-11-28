using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Asignacion_de_Agente
{
    public class Asignacion_de_AgentePagingModel
    {
        public List<Spartane.Core.Domain.Asignacion_de_Agente.Asignacion_de_Agente> Asignacion_de_Agentes { set; get; }
        public int RowCount { set; get; }
    }
}
