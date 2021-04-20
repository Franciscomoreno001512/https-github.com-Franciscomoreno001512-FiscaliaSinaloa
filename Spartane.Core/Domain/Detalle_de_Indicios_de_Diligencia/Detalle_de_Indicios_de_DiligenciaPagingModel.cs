using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia
{
    public class Detalle_de_Indicios_de_DiligenciaPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> Detalle_de_Indicios_de_Diligencias { set; get; }
        public int RowCount { set; get; }
    }
}
