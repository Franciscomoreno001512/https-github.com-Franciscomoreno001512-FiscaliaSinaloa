using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Servicios_Alternativos
{
    public class Servicios_AlternativosPagingModel
    {
        public List<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> Servicios_Alternativoss { set; get; }
        public int RowCount { set; get; }
    }
}
