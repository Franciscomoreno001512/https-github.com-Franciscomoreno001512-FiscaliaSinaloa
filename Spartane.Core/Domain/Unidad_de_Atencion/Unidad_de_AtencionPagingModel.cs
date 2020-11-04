using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Unidad_de_Atencion
{
    public class Unidad_de_AtencionPagingModel
    {
        public List<Spartane.Core.Domain.Unidad_de_Atencion.Unidad_de_Atencion> Unidad_de_Atencions { set; get; }
        public int RowCount { set; get; }
    }
}
