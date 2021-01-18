using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Domicilio
{
    public class Detalle_de_DomicilioPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_Domicilio> Detalle_de_Domicilios { set; get; }
        public int RowCount { set; get; }
    }
}
