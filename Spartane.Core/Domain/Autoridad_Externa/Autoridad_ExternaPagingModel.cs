using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Autoridad_Externa
{
    public class Autoridad_ExternaPagingModel
    {
        public List<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> Autoridad_Externas { set; get; }
        public int RowCount { set; get; }
    }
}
