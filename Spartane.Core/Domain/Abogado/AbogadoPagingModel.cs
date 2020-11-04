using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Abogado
{
    public class AbogadoPagingModel
    {
        public List<Spartane.Core.Domain.Abogado.Abogado> Abogados { set; get; }
        public int RowCount { set; get; }
    }
}
