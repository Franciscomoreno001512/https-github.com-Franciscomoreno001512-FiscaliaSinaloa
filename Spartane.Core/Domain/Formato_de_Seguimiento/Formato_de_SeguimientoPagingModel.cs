using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Formato_de_Seguimiento
{
    public class Formato_de_SeguimientoPagingModel
    {
        public List<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> Formato_de_Seguimientos { set; get; }
        public int RowCount { set; get; }
    }
}
