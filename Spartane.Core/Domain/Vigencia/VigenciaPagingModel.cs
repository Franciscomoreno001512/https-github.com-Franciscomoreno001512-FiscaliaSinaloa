using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Vigencia
{
    public class VigenciaPagingModel
    {
        public List<Spartane.Core.Domain.Vigencia.Vigencia> Vigencias { set; get; }
        public int RowCount { set; get; }
    }
}
