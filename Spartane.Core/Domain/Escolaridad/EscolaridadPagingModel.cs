using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Escolaridad
{
    public class EscolaridadPagingModel
    {
        public List<Spartane.Core.Domain.Escolaridad.Escolaridad> Escolaridads { set; get; }
        public int RowCount { set; get; }
    }
}
