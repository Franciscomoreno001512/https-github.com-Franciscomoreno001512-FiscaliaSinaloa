using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Formato_de_Control
{
    public class Formato_de_ControlPagingModel
    {
        public List<Spartane.Core.Domain.Formato_de_Control.Formato_de_Control> Formato_de_Controls { set; get; }
        public int RowCount { set; get; }
    }
}
