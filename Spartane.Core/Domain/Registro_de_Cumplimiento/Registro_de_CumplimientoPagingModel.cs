using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Registro_de_Cumplimiento
{
    public class Registro_de_CumplimientoPagingModel
    {
        public List<Spartane.Core.Domain.Registro_de_Cumplimiento.Registro_de_Cumplimiento> Registro_de_Cumplimientos { set; get; }
        public int RowCount { set; get; }
    }
}
