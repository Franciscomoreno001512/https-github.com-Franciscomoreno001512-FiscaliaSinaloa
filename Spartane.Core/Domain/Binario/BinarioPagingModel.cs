using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Binario
{
    public class BinarioPagingModel
    {
        public List<Spartane.Core.Domain.Binario.Binario> Binarios { set; get; }
        public int RowCount { set; get; }
    }
}
