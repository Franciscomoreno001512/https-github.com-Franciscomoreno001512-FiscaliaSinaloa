using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Datos_de_los_Hechos_PC
{
    public class Datos_de_los_Hechos_PCPagingModel
    {
        public List<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> Datos_de_los_Hechos_PCs { set; get; }
        public int RowCount { set; get; }
    }
}
