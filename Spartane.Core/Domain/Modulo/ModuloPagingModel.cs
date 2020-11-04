using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Modulo
{
    public class ModuloPagingModel
    {
        public List<Spartane.Core.Domain.Modulo.Modulo> Modulos { set; get; }
        public int RowCount { set; get; }
    }
}
