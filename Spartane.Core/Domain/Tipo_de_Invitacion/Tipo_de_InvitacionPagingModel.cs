using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Invitacion
{
    public class Tipo_de_InvitacionPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion> Tipo_de_Invitacions { set; get; }
        public int RowCount { set; get; }
    }
}
