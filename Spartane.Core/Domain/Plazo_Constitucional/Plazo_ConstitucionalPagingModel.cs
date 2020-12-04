using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Plazo_Constitucional
{
    public class Plazo_ConstitucionalPagingModel
    {
        public List<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional> Plazo_Constitucionals { set; get; }
        public int RowCount { set; get; }
    }
}
