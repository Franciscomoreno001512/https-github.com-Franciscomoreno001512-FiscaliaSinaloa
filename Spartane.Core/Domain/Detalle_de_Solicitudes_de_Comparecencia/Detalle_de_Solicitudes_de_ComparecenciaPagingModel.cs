using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Solicitudes_de_Comparecencia
{
    public class Detalle_de_Solicitudes_de_ComparecenciaPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Comparecencia.Detalle_de_Solicitudes_de_Comparecencia> Detalle_de_Solicitudes_de_Comparecencias { set; get; }
        public int RowCount { set; get; }
    }
}
