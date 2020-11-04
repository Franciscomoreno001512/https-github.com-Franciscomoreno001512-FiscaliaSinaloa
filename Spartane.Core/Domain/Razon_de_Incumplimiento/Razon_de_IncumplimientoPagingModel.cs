using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Razon_de_Incumplimiento
{
    public class Razon_de_IncumplimientoPagingModel
    {
        public List<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento> Razon_de_Incumplimientos { set; get; }
        public int RowCount { set; get; }
    }
}
