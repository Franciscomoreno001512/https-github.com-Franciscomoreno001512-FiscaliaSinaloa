using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Forma_Cabello
{
    public class Forma_CabelloPagingModel
    {
        public List<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello> Forma_Cabellos { set; get; }
        public int RowCount { set; get; }
    }
}
