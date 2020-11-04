using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Abogado
{
    public class Detalle_de_AbogadoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Abogado.Detalle_de_Abogado> Detalle_de_Abogados { set; get; }
        public int RowCount { set; get; }
    }
}
