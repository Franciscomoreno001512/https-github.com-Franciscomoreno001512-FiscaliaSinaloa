using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.PC_CanalizarA
{
    public class PC_CanalizarAPagingModel
    {
        public List<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> PC_CanalizarAs { set; get; }
        public int RowCount { set; get; }
    }
}
