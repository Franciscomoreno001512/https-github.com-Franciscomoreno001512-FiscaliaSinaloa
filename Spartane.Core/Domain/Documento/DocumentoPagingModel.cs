using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Documento
{
    public class DocumentoPagingModel
    {
        public List<Spartane.Core.Domain.Documento.Documento> Documentos { set; get; }
        public int RowCount { set; get; }
    }
}
