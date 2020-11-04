using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Agencia
{
    public class AgenciaPagingModel
    {
        public List<Spartane.Core.Domain.Agencia.Agencia> Agencias { set; get; }
        public int RowCount { set; get; }
    }
}
