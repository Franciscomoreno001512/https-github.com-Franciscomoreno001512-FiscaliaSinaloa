using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Codigo_Postal
{
    public class Codigo_PostalPagingModel
    {
        public List<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> Codigo_Postals { set; get; }
        public int RowCount { set; get; }
    }
}
