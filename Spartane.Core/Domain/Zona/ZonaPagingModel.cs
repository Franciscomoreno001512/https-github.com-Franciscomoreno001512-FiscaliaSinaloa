using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Zona
{
    public class ZonaPagingModel
    {
        public List<Spartane.Core.Domain.Zona.Zona> Zonas { set; get; }
        public int RowCount { set; get; }
    }
}
