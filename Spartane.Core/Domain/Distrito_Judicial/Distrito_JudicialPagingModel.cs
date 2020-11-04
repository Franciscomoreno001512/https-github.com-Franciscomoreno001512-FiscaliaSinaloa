using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Distrito_Judicial
{
    public class Distrito_JudicialPagingModel
    {
        public List<Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial> Distrito_Judicials { set; get; }
        public int RowCount { set; get; }
    }
}
