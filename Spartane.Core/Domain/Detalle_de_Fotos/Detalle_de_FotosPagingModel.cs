using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Fotos
{
    public class Detalle_de_FotosPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Fotos.Detalle_de_Fotos> Detalle_de_Fotoss { set; get; }
        public int RowCount { set; get; }
    }
}
