using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_de_Indicio
{
    public class Estatus_de_IndicioPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_de_Indicio.Estatus_de_Indicio> Estatus_de_Indicios { set; get; }
        public int RowCount { set; get; }
    }
}
