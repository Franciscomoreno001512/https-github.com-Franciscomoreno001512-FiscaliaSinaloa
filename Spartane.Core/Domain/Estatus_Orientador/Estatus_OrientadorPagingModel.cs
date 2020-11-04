using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_Orientador
{
    public class Estatus_OrientadorPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> Estatus_Orientadors { set; get; }
        public int RowCount { set; get; }
    }
}
