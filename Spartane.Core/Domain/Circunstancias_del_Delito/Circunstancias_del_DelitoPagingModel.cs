using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Circunstancias_del_Delito
{
    public class Circunstancias_del_DelitoPagingModel
    {
        public List<Spartane.Core.Domain.Circunstancias_del_Delito.Circunstancias_del_Delito> Circunstancias_del_Delitos { set; get; }
        public int RowCount { set; get; }
    }
}
