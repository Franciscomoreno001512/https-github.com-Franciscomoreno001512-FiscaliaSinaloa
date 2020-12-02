using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_Artefacto
{
    public class Tipo_ArtefactoPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto> Tipo_Artefactos { set; get; }
        public int RowCount { set; get; }
    }
}
