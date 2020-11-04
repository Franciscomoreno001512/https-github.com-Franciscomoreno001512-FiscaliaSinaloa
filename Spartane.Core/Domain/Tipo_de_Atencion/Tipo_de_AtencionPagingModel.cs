using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Atencion
{
    public class Tipo_de_AtencionPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Atencion.Tipo_de_Atencion> Tipo_de_Atencions { set; get; }
        public int RowCount { set; get; }
    }
}
