using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Acuerdo
{
    public class Tipo_de_AcuerdoPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo> Tipo_de_Acuerdos { set; get; }
        public int RowCount { set; get; }
    }
}
