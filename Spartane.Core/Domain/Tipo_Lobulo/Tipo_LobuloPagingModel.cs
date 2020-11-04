using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_Lobulo
{
    public class Tipo_LobuloPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_Lobulo.Tipo_Lobulo> Tipo_Lobulos { set; get; }
        public int RowCount { set; get; }
    }
}
