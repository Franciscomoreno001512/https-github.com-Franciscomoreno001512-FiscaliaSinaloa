using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Autoridad
{
    public class AutoridadPagingModel
    {
        public List<Spartane.Core.Domain.Autoridad.Autoridad> Autoridads { set; get; }
        public int RowCount { set; get; }
    }
}
