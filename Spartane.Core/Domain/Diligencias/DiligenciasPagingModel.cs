using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Diligencias
{
    public class DiligenciasPagingModel
    {
        public List<Spartane.Core.Domain.Diligencias.Diligencias> Diligenciass { set; get; }
        public int RowCount { set; get; }
    }
}
