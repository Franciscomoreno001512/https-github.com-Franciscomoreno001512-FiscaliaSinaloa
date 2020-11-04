using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Dialecto
{
    public class DialectoPagingModel
    {
        public List<Spartane.Core.Domain.Dialecto.Dialecto> Dialectos { set; get; }
        public int RowCount { set; get; }
    }
}
