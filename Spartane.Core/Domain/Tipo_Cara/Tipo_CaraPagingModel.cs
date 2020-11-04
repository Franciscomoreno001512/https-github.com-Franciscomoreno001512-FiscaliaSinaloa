using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_Cara
{
    public class Tipo_CaraPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_Cara.Tipo_Cara> Tipo_Caras { set; get; }
        public int RowCount { set; get; }
    }
}
