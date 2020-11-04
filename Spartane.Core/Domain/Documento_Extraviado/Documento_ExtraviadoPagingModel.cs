using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Documento_Extraviado
{
    public class Documento_ExtraviadoPagingModel
    {
        public List<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> Documento_Extraviados { set; get; }
        public int RowCount { set; get; }
    }
}
