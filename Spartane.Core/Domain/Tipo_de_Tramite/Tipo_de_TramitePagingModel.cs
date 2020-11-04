using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Tramite
{
    public class Tipo_de_TramitePagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Tramite.Tipo_de_Tramite> Tipo_de_Tramites { set; get; }
        public int RowCount { set; get; }
    }
}
