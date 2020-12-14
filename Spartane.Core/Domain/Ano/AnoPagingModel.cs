using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Ano
{
    public class AnoPagingModel
    {
        public List<Spartane.Core.Domain.Ano.Ano> Anos { set; get; }
        public int RowCount { set; get; }
    }
}
