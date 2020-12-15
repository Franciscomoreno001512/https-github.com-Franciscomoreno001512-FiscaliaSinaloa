using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Pension
{
    public class PensionPagingModel
    {
        public List<Spartane.Core.Domain.Pension.Pension> Pensions { set; get; }
        public int RowCount { set; get; }
    }
}
