using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Titulo_del_Delito
{
    public class Titulo_del_DelitoPagingModel
    {
        public List<Spartane.Core.Domain.Titulo_del_Delito.Titulo_del_Delito> Titulo_del_Delitos { set; get; }
        public int RowCount { set; get; }
    }
}
