using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Modulo_Atencion_Inicial
{
    public class Modulo_Atencion_InicialPagingModel
    {
        public List<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> Modulo_Atencion_Inicials { set; get; }
        public int RowCount { set; get; }
    }
}
