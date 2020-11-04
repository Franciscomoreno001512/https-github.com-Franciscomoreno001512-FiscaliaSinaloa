using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_del_Indicio
{
    public class Detalle_del_IndicioPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio> Detalle_del_Indicios { set; get; }
        public int RowCount { set; get; }
    }
}
