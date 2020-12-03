using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Documentos_Multimedia
{
    public class Documentos_MultimediaPagingModel
    {
        public List<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> Documentos_Multimedias { set; get; }
        public int RowCount { set; get; }
    }
}
