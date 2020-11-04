using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Coincidencias
{
    public class Detalle_de_CoincidenciasPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Coincidencias.Detalle_de_Coincidencias> Detalle_de_Coincidenciass { set; get; }
        public int RowCount { set; get; }
    }
}
