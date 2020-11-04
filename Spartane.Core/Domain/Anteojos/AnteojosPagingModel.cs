using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Anteojos
{
    public class AnteojosPagingModel
    {
        public List<Spartane.Core.Domain.Anteojos.Anteojos> Anteojoss { set; get; }
        public int RowCount { set; get; }
    }
}
