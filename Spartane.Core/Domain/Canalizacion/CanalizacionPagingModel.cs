using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Canalizacion
{
    public class CanalizacionPagingModel
    {
        public List<Spartane.Core.Domain.Canalizacion.Canalizacion> Canalizacions { set; get; }
        public int RowCount { set; get; }
    }
}
