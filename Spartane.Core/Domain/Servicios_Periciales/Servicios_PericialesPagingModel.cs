using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Servicios_Periciales
{
    public class Servicios_PericialesPagingModel
    {
        public List<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales> Servicios_Pericialess { set; get; }
        public int RowCount { set; get; }
    }
}
