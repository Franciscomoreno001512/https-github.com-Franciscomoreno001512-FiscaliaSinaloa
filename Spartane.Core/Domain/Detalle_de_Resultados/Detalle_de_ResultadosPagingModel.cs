using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Resultados
{
    public class Detalle_de_ResultadosPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Resultados.Detalle_de_Resultados> Detalle_de_Resultadoss { set; get; }
        public int RowCount { set; get; }
    }
}
