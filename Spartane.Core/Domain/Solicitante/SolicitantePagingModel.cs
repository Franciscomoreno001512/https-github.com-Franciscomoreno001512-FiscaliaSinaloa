using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Solicitante
{
    public class SolicitantePagingModel
    {
        public List<Spartane.Core.Domain.Solicitante.Solicitante> Solicitantes { set; get; }
        public int RowCount { set; get; }
    }
}
