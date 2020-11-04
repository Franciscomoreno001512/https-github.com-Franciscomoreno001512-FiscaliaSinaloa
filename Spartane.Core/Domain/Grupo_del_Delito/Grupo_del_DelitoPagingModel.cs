using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Grupo_del_Delito
{
    public class Grupo_del_DelitoPagingModel
    {
        public List<Spartane.Core.Domain.Grupo_del_Delito.Grupo_del_Delito> Grupo_del_Delitos { set; get; }
        public int RowCount { set; get; }
    }
}
