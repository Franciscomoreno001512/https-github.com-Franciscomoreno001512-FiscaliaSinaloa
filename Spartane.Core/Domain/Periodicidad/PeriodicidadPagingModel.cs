using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Periodicidad
{
    public class PeriodicidadPagingModel
    {
        public List<Spartane.Core.Domain.Periodicidad.Periodicidad> Periodicidads { set; get; }
        public int RowCount { set; get; }
    }
}
