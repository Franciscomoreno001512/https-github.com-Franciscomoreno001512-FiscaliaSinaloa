using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Audiencia_Inicial
{
    public class Audiencia_InicialPagingModel
    {
        public List<Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial> Audiencia_Inicials { set; get; }
        public int RowCount { set; get; }
    }
}
