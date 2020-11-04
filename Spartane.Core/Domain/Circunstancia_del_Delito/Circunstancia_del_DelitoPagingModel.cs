using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Circunstancia_del_Delito
{
    public class Circunstancia_del_DelitoPagingModel
    {
        public List<Spartane.Core.Domain.Circunstancia_del_Delito.Circunstancia_del_Delito> Circunstancia_del_Delitos { set; get; }
        public int RowCount { set; get; }
    }
}
