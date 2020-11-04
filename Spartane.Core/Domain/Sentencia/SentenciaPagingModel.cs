using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Sentencia
{
    public class SentenciaPagingModel
    {
        public List<Spartane.Core.Domain.Sentencia.Sentencia> Sentencias { set; get; }
        public int RowCount { set; get; }
    }
}
