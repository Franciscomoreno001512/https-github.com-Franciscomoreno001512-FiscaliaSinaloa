using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Certifica_Defuncion
{
    public class Certifica_DefuncionPagingModel
    {
        public List<Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion> Certifica_Defuncions { set; get; }
        public int RowCount { set; get; }
    }
}
