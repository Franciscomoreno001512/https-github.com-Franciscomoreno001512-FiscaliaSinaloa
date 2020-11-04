using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Etnia
{
    public class EtniaPagingModel
    {
        public List<Spartane.Core.Domain.Etnia.Etnia> Etnias { set; get; }
        public int RowCount { set; get; }
    }
}
