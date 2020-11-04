using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Colonia
{
    public class ColoniaPagingModel
    {
        public List<Spartane.Core.Domain.Colonia.Colonia> Colonias { set; get; }
        public int RowCount { set; get; }
    }
}
