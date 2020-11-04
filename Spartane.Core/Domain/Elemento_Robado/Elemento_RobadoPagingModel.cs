using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Elemento_Robado
{
    public class Elemento_RobadoPagingModel
    {
        public List<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> Elemento_Robados { set; get; }
        public int RowCount { set; get; }
    }
}
