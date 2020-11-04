using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado
{
    public class Clasificacion_en_Orden_de_ResultadoPagingModel
    {
        public List<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> Clasificacion_en_Orden_de_Resultados { set; get; }
        public int RowCount { set; get; }
    }
}
