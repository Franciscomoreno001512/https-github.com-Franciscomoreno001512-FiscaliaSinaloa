using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Nacionalidad
{
    public class NacionalidadPagingModel
    {
        public List<Spartane.Core.Domain.Nacionalidad.Nacionalidad> Nacionalidads { set; get; }
        public int RowCount { set; get; }
    }
}
