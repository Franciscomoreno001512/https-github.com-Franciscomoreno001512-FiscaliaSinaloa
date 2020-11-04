using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Expediente_Inicial
{
    public class Expediente_InicialPagingModel
    {
        public List<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> Expediente_Inicials { set; get; }
        public int RowCount { set; get; }
    }
}
