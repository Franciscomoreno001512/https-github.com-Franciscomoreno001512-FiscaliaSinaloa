using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.A_Tiempo
{
    public class A_TiempoPagingModel
    {
        public List<Spartane.Core.Domain.A_Tiempo.A_Tiempo> A_Tiempos { set; get; }
        public int RowCount { set; get; }
    }
}
