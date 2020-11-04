using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Convenio
{
    public class ConvenioPagingModel
    {
        public List<Spartane.Core.Domain.Convenio.Convenio> Convenios { set; get; }
        public int RowCount { set; get; }
    }
}
