using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Ambito
{
    public class AmbitoPagingModel
    {
        public List<Spartane.Core.Domain.Ambito.Ambito> Ambitos { set; get; }
        public int RowCount { set; get; }
    }
}
