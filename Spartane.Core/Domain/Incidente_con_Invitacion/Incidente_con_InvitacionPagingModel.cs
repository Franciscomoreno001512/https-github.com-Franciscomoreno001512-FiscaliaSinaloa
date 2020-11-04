using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Incidente_con_Invitacion
{
    public class Incidente_con_InvitacionPagingModel
    {
        public List<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion> Incidente_con_Invitacions { set; get; }
        public int RowCount { set; get; }
    }
}
