using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Oficios
{
    public class Tipo_de_OficiosPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Oficios.Tipo_de_Oficios> Tipo_de_Oficioss { set; get; }
        public int RowCount { set; get; }
    }
}
