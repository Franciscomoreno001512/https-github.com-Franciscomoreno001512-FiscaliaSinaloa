using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Medios_Alternativos
{
    public class Medios_AlternativosPagingModel
    {
        public List<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> Medios_Alternativoss { set; get; }
        public int RowCount { set; get; }
    }
}
