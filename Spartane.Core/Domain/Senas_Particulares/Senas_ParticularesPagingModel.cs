using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Senas_Particulares
{
    public class Senas_ParticularesPagingModel
    {
        public List<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> Senas_Particularess { set; get; }
        public int RowCount { set; get; }
    }
}
