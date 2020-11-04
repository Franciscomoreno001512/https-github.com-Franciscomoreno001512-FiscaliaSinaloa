using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Resultado_de_Revision
{
    public class Resultado_de_RevisionPagingModel
    {
        public List<Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision> Resultado_de_Revisions { set; get; }
        public int RowCount { set; get; }
    }
}
