using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Documento_MPO
{
    public class Detalle_de_Documento_MPOPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Documento_MPO.Detalle_de_Documento_MPO> Detalle_de_Documento_MPOs { set; get; }
        public int RowCount { set; get; }
    }
}
