using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Calvicie
{
    public class CalviciePagingModel
    {
        public List<Spartane.Core.Domain.Calvicie.Calvicie> Calvicies { set; get; }
        public int RowCount { set; get; }
    }
}
