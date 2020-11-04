using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Ojos
{
    public class OjosPagingModel
    {
        public List<Spartane.Core.Domain.Ojos.Ojos> Ojoss { set; get; }
        public int RowCount { set; get; }
    }
}
