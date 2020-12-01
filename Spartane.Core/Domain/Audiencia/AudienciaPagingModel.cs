using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Audiencia
{
    public class AudienciaPagingModel
    {
        public List<Spartane.Core.Domain.Audiencia.Audiencia> Audiencias { set; get; }
        public int RowCount { set; get; }
    }
}
