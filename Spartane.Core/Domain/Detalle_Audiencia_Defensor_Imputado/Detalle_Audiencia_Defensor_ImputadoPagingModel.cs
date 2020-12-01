using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Audiencia_Defensor_Imputado
{
    public class Detalle_Audiencia_Defensor_ImputadoPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Imputado.Detalle_Audiencia_Defensor_Imputado> Detalle_Audiencia_Defensor_Imputados { set; get; }
        public int RowCount { set; get; }
    }
}
