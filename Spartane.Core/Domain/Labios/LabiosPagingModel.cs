using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Labios
{
    public class LabiosPagingModel
    {
        public List<Spartane.Core.Domain.Labios.Labios> Labioss { set; get; }
        public int RowCount { set; get; }
    }
}
