using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Juez_de_Control
{
    public class Juez_de_ControlPagingModel
    {
        public List<Spartane.Core.Domain.Juez_de_Control.Juez_de_Control> Juez_de_Controls { set; get; }
        public int RowCount { set; get; }
    }
}
