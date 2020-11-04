using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Grupo_Vulnerable
{
    public class Grupo_VulnerablePagingModel
    {
        public List<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> Grupo_Vulnerables { set; get; }
        public int RowCount { set; get; }
    }
}
