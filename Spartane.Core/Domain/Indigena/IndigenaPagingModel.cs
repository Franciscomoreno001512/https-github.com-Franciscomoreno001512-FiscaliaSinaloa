using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Indigena
{
    public class IndigenaPagingModel
    {
        public List<Spartane.Core.Domain.Indigena.Indigena> Indigenas { set; get; }
        public int RowCount { set; get; }
    }
}
