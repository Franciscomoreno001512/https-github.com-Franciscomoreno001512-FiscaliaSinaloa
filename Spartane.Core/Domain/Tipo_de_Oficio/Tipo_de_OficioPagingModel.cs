using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Oficio
{
    public class Tipo_de_OficioPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Oficio.Tipo_de_Oficio> Tipo_de_Oficios { set; get; }
        public int RowCount { set; get; }
    }
}
