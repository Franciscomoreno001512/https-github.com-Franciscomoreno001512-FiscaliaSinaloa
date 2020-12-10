using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Modulo_Encuesta
{
    public class Modulo_EncuestaPagingModel
    {
        public List<Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta> Modulo_Encuestas { set; get; }
        public int RowCount { set; get; }
    }
}
