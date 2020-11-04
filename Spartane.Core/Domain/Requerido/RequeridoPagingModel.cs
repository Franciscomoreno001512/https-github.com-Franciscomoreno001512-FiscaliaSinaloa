using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Requerido
{
    public class RequeridoPagingModel
    {
        public List<Spartane.Core.Domain.Requerido.Requerido> Requeridos { set; get; }
        public int RowCount { set; get; }
    }
}
