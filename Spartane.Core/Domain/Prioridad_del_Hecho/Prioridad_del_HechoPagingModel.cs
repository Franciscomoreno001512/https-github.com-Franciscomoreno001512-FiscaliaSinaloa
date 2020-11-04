using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Prioridad_del_Hecho
{
    public class Prioridad_del_HechoPagingModel
    {
        public List<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> Prioridad_del_Hechos { set; get; }
        public int RowCount { set; get; }
    }
}
