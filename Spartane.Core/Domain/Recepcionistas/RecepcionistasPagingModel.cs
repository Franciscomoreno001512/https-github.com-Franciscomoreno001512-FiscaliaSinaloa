using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Recepcionistas
{
    public class RecepcionistasPagingModel
    {
        public List<Spartane.Core.Domain.Recepcionistas.Recepcionistas> Recepcionistass { set; get; }
        public int RowCount { set; get; }
    }
}
