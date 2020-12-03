using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Plantio
{
    public class Tipo_de_PlantioPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio> Tipo_de_Plantios { set; get; }
        public int RowCount { set; get; }
    }
}
