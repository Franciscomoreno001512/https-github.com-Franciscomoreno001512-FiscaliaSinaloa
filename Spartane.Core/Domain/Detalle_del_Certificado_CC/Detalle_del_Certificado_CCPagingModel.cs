using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_del_Certificado_CC
{
    public class Detalle_del_Certificado_CCPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_del_Certificado_CC.Detalle_del_Certificado_CC> Detalle_del_Certificado_CCs { set; get; }
        public int RowCount { set; get; }
    }
}
