using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Unidad
{
    public class UnidadPagingModel
    {
        public List<Spartane.Core.Domain.Unidad.Unidad> Unidads { set; get; }
        public int RowCount { set; get; }
    }
}
