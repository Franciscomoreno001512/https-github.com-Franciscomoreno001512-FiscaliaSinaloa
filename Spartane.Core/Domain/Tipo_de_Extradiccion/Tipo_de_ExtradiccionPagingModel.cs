using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Extradiccion
{
    public class Tipo_de_ExtradiccionPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Extradiccion.Tipo_de_Extradiccion> Tipo_de_Extradiccions { set; get; }
        public int RowCount { set; get; }
    }
}
