using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Acuerdos_MASC
{
    public class Acuerdos_MASCPagingModel
    {
        public List<Spartane.Core.Domain.Acuerdos_MASC.Acuerdos_MASC> Acuerdos_MASCs { set; get; }
        public int RowCount { set; get; }
    }
}
