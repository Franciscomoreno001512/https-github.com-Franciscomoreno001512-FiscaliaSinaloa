using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Localidad
{
    public class LocalidadPagingModel
    {
        public List<Spartane.Core.Domain.Localidad.Localidad> Localidads { set; get; }
        public int RowCount { set; get; }
    }
}
