using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Aseguramientos
{
    public class AseguramientosPagingModel
    {
        public List<Spartane.Core.Domain.Aseguramientos.Aseguramientos> Aseguramientoss { set; get; }
        public int RowCount { set; get; }
    }
}
