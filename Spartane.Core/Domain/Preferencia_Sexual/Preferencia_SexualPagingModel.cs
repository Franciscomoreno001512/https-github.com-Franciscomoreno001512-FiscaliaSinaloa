using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Preferencia_Sexual
{
    public class Preferencia_SexualPagingModel
    {
        public List<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> Preferencia_Sexuals { set; get; }
        public int RowCount { set; get; }
    }
}
