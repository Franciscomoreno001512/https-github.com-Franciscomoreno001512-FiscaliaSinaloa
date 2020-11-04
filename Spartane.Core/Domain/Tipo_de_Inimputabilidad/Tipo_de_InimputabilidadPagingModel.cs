using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Inimputabilidad
{
    public class Tipo_de_InimputabilidadPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Inimputabilidad.Tipo_de_Inimputabilidad> Tipo_de_Inimputabilidads { set; get; }
        public int RowCount { set; get; }
    }
}
