using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Barba
{
    public class BarbaPagingModel
    {
        public List<Spartane.Core.Domain.Barba.Barba> Barbas { set; get; }
        public int RowCount { set; get; }
    }
}
