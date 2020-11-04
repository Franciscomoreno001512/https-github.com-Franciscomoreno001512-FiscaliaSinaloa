using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Indicios
{
    public class IndiciosPagingModel
    {
        public List<Spartane.Core.Domain.Indicios.Indicios> Indicioss { set; get; }
        public int RowCount { set; get; }
    }
}
