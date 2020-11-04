using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Unidad_de_Atenciòn
{
    public class Unidad_de_AtenciònPagingModel
    {
        public List<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> Unidad_de_Atenciòns { set; get; }
        public int RowCount { set; get; }
    }
}
