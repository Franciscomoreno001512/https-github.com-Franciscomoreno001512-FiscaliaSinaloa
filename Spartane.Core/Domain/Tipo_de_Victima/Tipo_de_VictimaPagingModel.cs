using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Victima
{
    public class Tipo_de_VictimaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Victima.Tipo_de_Victima> Tipo_de_Victimas { set; get; }
        public int RowCount { set; get; }
    }
}
