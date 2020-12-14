using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Resumen_Denuncia
{
    public class Detalle_Resumen_DenunciaPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> Detalle_Resumen_Denuncias { set; get; }
        public int RowCount { set; get; }
    }
}
